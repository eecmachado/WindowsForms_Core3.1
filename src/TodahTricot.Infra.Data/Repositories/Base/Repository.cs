using AutoMapper;
using NHibernate;
using System.Collections.Generic;
using System.Linq;
using TodahTricot.Application.Interfaces.Repositories.Base;
using TodahTricot.Domain.Entities.Base;
using TodahTricot.Infra.Data.DataModels.Base;

namespace TodahTricot.Infra.Data.Repositories.Base
{
    public abstract class Repository<TDomainModel, TDataModel> : IRepository<TDomainModel>
        where TDomainModel : IDomainModel
        where TDataModel : IDataModel
    {
        protected readonly ISessionFactory sessionFactory;
        protected readonly IMapper mapper;

        public Repository(ISessionFactory sessionFactory, IMapper mapper)
        {
            this.sessionFactory = sessionFactory;
            this.mapper = mapper;
        }

        public virtual TDomainModel Inserir(TDomainModel domainModel)
        {
            var dataModel = mapper.Map<TDataModel>(domainModel);

            using (var session = sessionFactory.OpenSession())
            {
                session.Save(dataModel);
                session.Flush();
                domainModel.Id = dataModel.Id;
                return domainModel;
            }
        }

        public virtual TDomainModel Alterar(TDomainModel domainModel)
        {
            var dataModel = mapper.Map<TDataModel>(domainModel);

            using (var session = sessionFactory.OpenSession())
            {
                session.Update(dataModel);
                session.Flush();
                return domainModel;
            }
        }

        public virtual void Excluir(int id)
        {
            using (var session = sessionFactory.OpenSession())
            {
                session.Delete(session.Load<TDataModel>(id));
                session.Flush();
            }
        }

        public TDomainModel ObterPorId(int id)
        {
            using (var session = sessionFactory.OpenSession())
            {
                var dataModel = session.Get<TDataModel>(id);
                return mapper.Map<TDomainModel>(dataModel);
            }
        }

        public IEnumerable<TDomainModel> ObterLista()
        {
            using (var session = sessionFactory.OpenSession())
            {
                var lista = session.Query<TDataModel>().ToList();
                return mapper.Map<IEnumerable<TDomainModel>>(lista);
            }
        }

        public bool Existe(int id)
        {
            using (var session = sessionFactory.OpenSession())
            {
                return session.Query<TDataModel>().Any(a => a.Id == id);
            }
        }
    }
}

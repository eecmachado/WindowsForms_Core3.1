using AutoMapper;
using NHibernate;
using System.Linq;
using TodahTricot.Application.Interfaces.Repositories;
using TodahTricot.Domain.Entities;
using TodahTricot.Infra.Data.DataModels;
using TodahTricot.Infra.Data.Repositories.Base;

namespace TodahTricot.Infra.Data.Repositories
{
    public class DespesaRepository : Repository<DespesaModel, DespesaData>, IDespesaRepository
    {
        public DespesaRepository(ISessionFactory sessionFactory, IMapper mapper)
            : base(sessionFactory, mapper)
        {
        }

        public DespesaModel ObterPorCodigo(string codigo)
        {
            using (var session = sessionFactory.OpenSession())
            {
                var despesaData = session.Query<DespesaData>().FirstOrDefault(a => a.Codigo == codigo);

                return mapper.Map<DespesaModel>(despesaData);
            }
        }
    }
}

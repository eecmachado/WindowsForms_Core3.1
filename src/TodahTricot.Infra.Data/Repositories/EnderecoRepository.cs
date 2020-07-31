using AutoMapper;
using NHibernate;
using System.Linq;
using TodahTricot.Application.Interfaces.Repositories;
using TodahTricot.Domain.Entities;
using TodahTricot.Infra.Data.DataModels;
using TodahTricot.Infra.Data.Repositories.Base;

namespace TodahTricot.Infra.Data.Repositories
{
    public class EnderecoRepository : Repository<EnderecoModel, EnderecoData>, IEnderecoRepository
    {
        public EnderecoRepository(ISessionFactory sessionFactory, IMapper mapper) 
            : base(sessionFactory, mapper)
        {
        }

        public EnderecoModel ObterPorCep(string cep)
        {
            using (var session = sessionFactory.OpenSession())
            {
                var enderecoModel = session.Query<EnderecoData>().FirstOrDefault(a => a.Cep == cep);

                return mapper.Map<EnderecoModel>(enderecoModel);
            }
        }
    }
}

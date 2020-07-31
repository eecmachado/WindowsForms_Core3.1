using AutoMapper;
using NHibernate;
using System.Linq;
using TodahTricot.Application.Interfaces.Repositories;
using TodahTricot.Domain.Entities;
using TodahTricot.Infra.Data.DataModels;
using TodahTricot.Infra.Data.Repositories.Base;

namespace TodahTricot.Infra.Data.Repositories
{
    public class CorRepository : Repository<CorModel, CorData>, ICorRepository
    {
        public CorRepository(ISessionFactory sessionFactory, IMapper mapper)
            : base(sessionFactory, mapper)
        {
        }

        public CorModel ObterPorCodigo(string codigo)
        {
            using (var session = sessionFactory.OpenSession())
            {
                var corData = session.Query<CorData>().FirstOrDefault(a => a.Codigo == codigo);

                return mapper.Map<CorModel>(corData);
            }
        }
    }
}

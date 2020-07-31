using AutoMapper;
using NHibernate;
using TodahTricot.Application.Interfaces.Repositories;
using TodahTricot.Domain.Entities;
using TodahTricot.Infra.Data.DataModels;
using TodahTricot.Infra.Data.Repositories.Base;

namespace TodahTricot.Infra.Data.Repositories
{
    public class FornecedorRepository : Repository<FornecedorModel, FornecedorData>, IFornecedorRepository
    {
        public FornecedorRepository(ISessionFactory sessionFactory, IMapper mapper)
            : base(sessionFactory, mapper)
        {
        }
    }
}

using TodahTricot.Application.Interfaces.Repositories.Base;
using TodahTricot.Domain.Entities;

namespace TodahTricot.Application.Interfaces.Repositories
{
    public interface ICorRepository : IRepository<CorModel>
    {
        CorModel ObterPorCodigo(string codigo);
    }
}

using TodahTricot.Application.Interfaces.Repositories.Base;
using TodahTricot.Domain.Entities;

namespace TodahTricot.Application.Interfaces.Repositories
{
    public interface IDespesaRepository : IRepository<DespesaModel>
    {
        DespesaModel ObterPorCodigo(string codigo);
    }
}

using TodahTricot.Application.Interfaces.Repositories.Base;
using TodahTricot.Domain.Entities;

namespace TodahTricot.Application.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepository<ProdutoModel>
    {
        ProdutoModel ObterPorCodigo(string codigo);
    }
}

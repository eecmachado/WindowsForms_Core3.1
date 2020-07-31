using TodahTricot.Application.Interfaces.Repositories.Base;
using TodahTricot.Domain.Entities;

namespace TodahTricot.Application.Interfaces.Repositories
{
    public interface IEnderecoRepository : IRepository<EnderecoModel>
    {
        EnderecoModel ObterPorCep(string cep);
    }
}

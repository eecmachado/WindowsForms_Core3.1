using System.Collections.Generic;
using TodahTricot.Domain.Entities.Base;

namespace TodahTricot.Application.Interfaces.Repositories.Base
{
    public interface IRepository<TDomainModel> where TDomainModel : IDomainModel
    {
        TDomainModel Inserir(TDomainModel domainModel);
        TDomainModel Alterar(TDomainModel domainModel);
        void Excluir(int id);
        TDomainModel ObterPorId(int id);
        IEnumerable<TDomainModel> ObterLista();
        bool Existe(int id);        
    }
}

using System;
using TodahTricot.Domain.Entities.Base;

namespace TodahTricot.Domain.Entities
{
    public class ClienteModel : DomainModel
    {
        public ClienteModel() => Novo = true;
        public ClienteModel(bool novo) => Novo = novo;

        public string Email { get; set; }
        public string NomeCompleto { get; set; }
        public EnderecoModel Endereco { get; set; }
        public string TipoDeDocumento { get; set; }
        public string Documento { get; set; }
    }
}

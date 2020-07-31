using TodahTricot.Domain.Entities.Base;

namespace TodahTricot.Domain.Entities
{
    public class EnderecoModel : DomainModel
    {
        public EnderecoModel() => Novo = true;
        public EnderecoModel(bool novo) => Novo = novo;

        public string Cep { get; set; }

        public string Municipio { get; set; }

        public string Uf { get; set; }

        public string Endereco { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }
    }
}

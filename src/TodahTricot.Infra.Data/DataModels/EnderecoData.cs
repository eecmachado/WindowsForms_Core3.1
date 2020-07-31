using TodahTricot.Infra.Data.DataModels.Base;

namespace TodahTricot.Infra.Data.DataModels
{
    public class EnderecoData : DataModel
    {
        public virtual string Cep { get; set; }

        public virtual string Municipio { get; set; }

        public virtual string Uf { get; set; }

        public virtual string Endereco { get; set; }

        public virtual string Numero { get; set; }

        public virtual string Complemento { get; set; }
    }
}

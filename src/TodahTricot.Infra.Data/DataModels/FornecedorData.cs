using TodahTricot.Infra.Data.DataModels.Base;

namespace TodahTricot.Infra.Data.DataModels
{
    public class FornecedorData : DataModel
    {
        public virtual string Email { get; set; }
        public virtual string NomeCompleto { get; set; }
        public virtual EnderecoData Endereco { get; set; }
        public virtual string TipoDeDocumento { get; set; }
        public virtual string Documento { get; set; }
    }
}

using TodahTricot.Infra.Data.DataModels;

namespace TodahTricot.Infra.Data.Mappings
{
    public class FornecedorMap : MapBase<FornecedorData>
    {
        public FornecedorMap()
        {
            CreateIdColumn("Fornecedor", "Id");
            Map(m => m.Email, "Email");
            Map(m => m.NomeCompleto, "NomeCompleto");        
            Map(m => m.TipoDeDocumento, "TipoDeDocumento");
            Map(m => m.Documento, "Documento");
            References(r => r.Endereco, "EnderecoId");
        }
    }
}

using TodahTricot.Infra.Data.DataModels;

namespace TodahTricot.Infra.Data.Mappings
{
    public class EnderecoMap : MapBase<EnderecoData>
    {
        public EnderecoMap()
        {
            CreateIdColumn("Endereco", "Id");
            Map(m => m.Cep, "Cep");
            Map(m => m.Uf, "Uf");
            Map(m => m.Municipio, "Municipio");
            Map(m => m.Endereco, "Endereco");
            Map(m => m.Numero, "Numero");
            Map(m => m.Complemento, "Complemento");

        }
    }
}

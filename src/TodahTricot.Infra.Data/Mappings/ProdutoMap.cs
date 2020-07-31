using TodahTricot.Infra.Data.DataModels;

namespace TodahTricot.Infra.Data.Mappings
{
    public class ProdutoMap : MapBase<ProdutoData>
    {
        public ProdutoMap()
        {
            CreateIdColumn("Produto", "Id");
            Map(m => m.Codigo, "Codigo");
            Map(m => m.Descricao, "Descricao");
            References(r => r.Imagem, "ImagemId");
        }
    }
}

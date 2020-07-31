using TodahTricot.Infra.Data.DataModels.Base;

namespace TodahTricot.Infra.Data.DataModels
{
    public class ProdutoData : DataModel
    {
        public virtual string Codigo { get; set; }

        public virtual ImagemData Imagem { get; set; }
        public virtual string Descricao { get; set; }
    }
}

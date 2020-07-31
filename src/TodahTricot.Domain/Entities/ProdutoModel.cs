using TodahTricot.Domain.Entities.Base;

namespace TodahTricot.Domain.Entities
{
    public class ProdutoModel : DomainModel
    {
        public ProdutoModel() => Novo = true;
        public ProdutoModel(bool novo) => Novo = novo;
        public string Codigo { get; set; }

        public ImagemModel Imagem { get; set; }

        public string Descricao { get; set; }
    }
}

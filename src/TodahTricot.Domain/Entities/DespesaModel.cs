using TodahTricot.Domain.Entities.Base;

namespace TodahTricot.Domain.Entities
{
    public class DespesaModel : DomainModel
    {
        public DespesaModel() => Novo = true;
        public DespesaModel(bool novo) => Novo = novo;
        public string Codigo { get; set; }

        public ImagemModel Imagem { get; set; }

        public string Descricao { get; set; }
    }
}

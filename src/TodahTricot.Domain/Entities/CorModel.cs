using TodahTricot.Domain.Entities.Base;

namespace TodahTricot.Domain.Entities
{
    public class CorModel : DomainModel
    {
        public CorModel() => Novo = true;
        public CorModel(bool novo) => Novo = novo;

        public string Codigo { get; set; }
        public string Descricao { get; set; }
    }
}

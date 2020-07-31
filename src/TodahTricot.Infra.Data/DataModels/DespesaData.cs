using TodahTricot.Infra.Data.DataModels.Base;

namespace TodahTricot.Infra.Data.DataModels
{
    public class DespesaData : DataModel
    {
        public virtual string Codigo { get; set; }
        public virtual string Descricao { get; set; }
    }
}

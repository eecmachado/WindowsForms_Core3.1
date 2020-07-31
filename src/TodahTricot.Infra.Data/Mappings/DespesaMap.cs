using TodahTricot.Infra.Data.DataModels;

namespace TodahTricot.Infra.Data.Mappings
{
    public class DespesaMap : MapBase<DespesaData>
    {
        public DespesaMap()
        {
            CreateIdColumn("Despesa", "Id");
            Map(m => m.Codigo, "Codigo");
            Map(m => m.Descricao, "Descricao");
        }
    }
}

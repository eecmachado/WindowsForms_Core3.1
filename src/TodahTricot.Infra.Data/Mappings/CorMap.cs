using TodahTricot.Infra.Data.DataModels;

namespace TodahTricot.Infra.Data.Mappings
{
    public class CorMap : MapBase<CorData>
    {
        public CorMap()
        {
            CreateIdColumn("Cor", "Id");
            Map(m => m.Codigo, "Codigo");
            Map(m => m.Descricao, "Descricao");
        }
    }
}

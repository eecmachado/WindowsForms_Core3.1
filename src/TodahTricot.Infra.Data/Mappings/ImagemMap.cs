using TodahTricot.Infra.Data.DataModels;

namespace TodahTricot.Infra.Data.Mappings
{
    public class ImagemMap : MapBase<ImagemData>
    {
        public ImagemMap()
        {
            CreateIdColumn("Imagem", "Id");
            Map(m => m.Arquivo, "Arquivo").Length(int.MaxValue);
        }
    }
}

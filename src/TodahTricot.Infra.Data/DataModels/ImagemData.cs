using TodahTricot.Infra.Data.DataModels.Base;

namespace TodahTricot.Infra.Data.DataModels
{
    public class ImagemData : DataModel
    {
        public virtual byte[] Arquivo { get; set; }
    }
}

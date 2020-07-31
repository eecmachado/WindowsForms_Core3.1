using FluentNHibernate.Mapping;
using TodahTricot.Infra.Data.DataModels.Base;

namespace TodahTricot.Infra.Data.Mappings
{
    public abstract class MapBase<T> : ClassMap<T> where T : IDataModel
    {
        protected MapBase(bool lazyLoad = true)
        {
            DynamicUpdate();
            if (lazyLoad)
                LazyLoad();
        }

        protected virtual void CreateIdColumn(string tableName, string columnName, bool createSequence = true)
        {
            Table(tableName);

            if (createSequence)
                Id(x => x.Id).Column(columnName).GeneratedBy
                    .Native(builder => builder.AddParam("sequence", "SEQ_" + tableName));
            else
                Id(x => x.Id).Column(columnName);

        }
    }
}

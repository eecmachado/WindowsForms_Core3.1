using System;

namespace TodahTricot.Infra.Data.Configurations
{
    public class SessionFactoryConfiguration
    { 
        public string ConnectionString { get; set; }

        public bool ShowSql { get; set; }

        public void Configuration(Action<NHibernate.Cfg.Configuration> configuration)
        {
            ActionConfiguration = configuration;
        }

        internal Action<NHibernate.Cfg.Configuration> ActionConfiguration { get; private set; }
    }
}

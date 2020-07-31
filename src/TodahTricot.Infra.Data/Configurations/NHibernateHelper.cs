using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Reflection;

namespace TodahTricot.Infra.Data.Configurations
{
    public static class NHibernateHelper
    {
        public static ISessionFactory ConfigureSessionFactory(Action<SessionFactoryConfiguration> Configuration)
        {
            var so = new SessionFactoryConfiguration();
            Configuration(so);

            return InitializeSessionFactory(so.ConnectionString, so.ShowSql, so.ActionConfiguration);
        }

        private static ISessionFactory InitializeSessionFactory(string connString, bool showSql,
            Action<Configuration> configuration)
        {
            var dbConfig = InitializePersistenceConfigurer(connString, showSql);
            var fluentConfiguration = InitializeFluentConfiguration(dbConfig, configuration);
            return fluentConfiguration.BuildSessionFactory();
        }

        private static IPersistenceConfigurer InitializePersistenceConfigurer(string connString, bool showSql)
        {
            IPersistenceConfigurer dbConfig;

            if (showSql)
                dbConfig = MsSqlConfiguration.MsSql2012.ConnectionString(connString).ShowSql();
            else
                dbConfig = MsSqlConfiguration.MsSql2012.ConnectionString(connString);

            return dbConfig;
        }

        private static FluentConfiguration InitializeFluentConfiguration(IPersistenceConfigurer dbConfig, Action<Configuration> configuration)
        {
            var fluentConfiguration = Fluently.Configure();

            fluentConfiguration.Database(dbConfig);
            //fluentConfiguration.CurrentSessionContext("web");

            if (configuration != null)
                fluentConfiguration.ExposeConfiguration(configuration);

            ConfigureAssemblies(ref fluentConfiguration);
            return fluentConfiguration;
        }

        private static void ConfigureAssemblies(ref FluentConfiguration configuration)
        {
            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (var attribute in assembly.GetCustomAttributes(true))
                {
                    if (attribute is HibernatePersistenceAttribute)
                    {
                        Assembly bgmAssembly = assembly;
                        configuration.Mappings(m => m.FluentMappings.AddFromAssembly(bgmAssembly));
                    }
                }
            }
        }
    }
}

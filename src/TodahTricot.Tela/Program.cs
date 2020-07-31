using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using TodahTricot.Application.Interfaces.Repositories;
using TodahTricot.Infra.CrossCutting.AutoMapper;
using TodahTricot.Infra.Data.Repositories;
using TodahTricot.Tela.Auxiliar;
using TodahTricot.Tela.Cadastro;
using teste = System.Windows.Forms;

namespace TodahTricot.Tela
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            teste.Application.SetHighDpiMode(teste.HighDpiMode.SystemAware);
            teste.Application.EnableVisualStyles();
            teste.Application.SetCompatibleTextRenderingDefault(false);

            var host = Host.CreateDefaultBuilder()
             .ConfigureAppConfiguration((context, builder) =>
             {
                 // Add other configuration files...
                 builder.AddJsonFile("appsettings.json", optional: true);
             })
             .ConfigureServices((context, services) =>
             {
                 ConfigureServices(context.Configuration, services);
             })
             .ConfigureLogging(logging =>
             {
                 // Add other loggers...
             })
             .Build();

            var services = host.Services;
            var mainForm = services.GetRequiredService<FrmMenu>();


            teste.Application.Run(mainForm);
        }

        static void ConfigureServices(IConfiguration configuration, IServiceCollection services)
        {
            services.AddAutoMapper(config =>
            {
                config.ForAllMaps((map, expression) =>
                {
                    foreach (var unmappedPropertyName in map.GetUnmappedPropertyNames())
                        expression.ForMember(unmappedPropertyName,
                            configurationExpression => configurationExpression.Ignore());
                });

                config.AddProfiles(typeof(ApplicationProfile).Assembly);
            });

            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<AutoMapper.IConfigurationProvider>(), sp.GetService));

            services.AddSingleton<FrmMenu>();
            services.AddTransient<FrmProduto>();
            services.AddTransient<FrmCor>();
            services.AddTransient<FrmDespesa>();
            //services.AddTransient<FrmFornecedor>();
            services.AddTransient<FrmCliente>();
            services.AddTransient<FrmPesquisa>();

            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IImagemRepository, ImagemRepository>();
            services.AddScoped<ICorRepository, CorRepository>();
            services.AddScoped<IDespesaRepository, DespesaRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var sessionFactory = Infra.Data.Configurations.NHibernateHelper.ConfigureSessionFactory(a =>
            {
                a.ConnectionString = connectionString;
            });

            services.AddSingleton(sessionFactory);
        }
    }
}

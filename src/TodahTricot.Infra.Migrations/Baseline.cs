using FluentMigrator;
using TodahTricot.Infra.Migrations.Base;

namespace TodahTricot.Infra.Migrations
{
    [MigrationBase(1, "Todah")]
    public class Baseline : Migration
    {
        public override void Up()
        {
            Create.Table("Imagem")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("Arquivo").AsBinary(int.MaxValue).NotNullable();

            Create.Table("Produto")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("Codigo").AsAnsiString(6).NotNullable().Unique()
                .WithColumn("ImagemId").AsInt32().Nullable().Unique()
                .WithColumn("Descricao").AsAnsiString(50).NotNullable();            

            Create.ForeignKey("fk_Produto_Imagem")
                .FromTable("Produto")
                .ForeignColumns("ImagemId")
                .ToTable("Imagem")
                .PrimaryColumns("Id");

            Create.Table("Cor")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("Codigo").AsAnsiString(6).NotNullable().Unique()
                .WithColumn("Descricao").AsAnsiString(50).NotNullable();

            Create.Table("Despesa")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("Codigo").AsAnsiString(6).NotNullable().Unique()
                .WithColumn("Descricao").AsAnsiString(50).NotNullable();

            Create.Table("Endereco")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("Cep").AsAnsiString(8).NotNullable()
                .WithColumn("Municipio").AsAnsiString(50).NotNullable()
                .WithColumn("Uf").AsAnsiString(2).NotNullable()
                .WithColumn("Endereco").AsAnsiString(100).NotNullable()
                .WithColumn("Numero").AsAnsiString(15).Nullable()
                .WithColumn("Complemento").AsAnsiString(30).Nullable();

            Create.Index("idx_Endereco_Cep").OnTable("Endereco")
                .OnColumn("Cep").Ascending();

            Create.Table("Cliente")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("Email").AsAnsiString(50).Nullable()
                .WithColumn("NomeCompleto").AsAnsiString(20).NotNullable()
                .WithColumn("EnderecoId").AsInt32().NotNullable()
                .WithColumn("TipoDeDocumento").AsAnsiString(4).NotNullable()
                .WithColumn("Documento").AsAnsiString(14).NotNullable();

            Create.Index("idx_Cliente_TipoDeDocumento_Documento").OnTable("Cliente")
                .OnColumn("TipoDeDocumento").Ascending()
                .OnColumn("Documento").Ascending()
            .WithOptions().Unique();

            Create.Index("idx_Cliente_Email").OnTable("Cliente")
                .OnColumn("Email").Ascending()
            .WithOptions();

            Create.Table("Fornecedor")
               .WithColumn("Id").AsInt32().Identity().PrimaryKey().NotNullable()
               .WithColumn("Email").AsAnsiString(50).Nullable()
               .WithColumn("NomeCompleto").AsAnsiString(20).NotNullable()
               .WithColumn("EnderecoId").AsInt32().NotNullable()
               .WithColumn("TipoDeDocumento").AsAnsiString(4).Nullable()
               .WithColumn("Documento").AsAnsiString(14).Nullable();

            Create.Index("idx_Fornecedor_TipoDeDocumento_Documento").OnTable("Fornecedor")
                .OnColumn("TipoDeDocumento").Ascending()
                .OnColumn("Documento").Ascending()
            .WithOptions();

            Create.Index("idx_Fornecedor_Email").OnTable("Fornecedor")
                .OnColumn("Email").Ascending()
            .WithOptions();
        }

        public override void Down()
        {           
            Delete.Table("Produto");
            Delete.Table("Imagem");
            Delete.Table("Cor");
            Delete.Table("Despesa");
            Delete.Table("Cliente");
            Delete.Table("Fornecedor");
            Delete.Table("Endereco");            
        }
    }

    [Migration(0)]
    public class Setup : Migration
    {
        public override void Up()
        {

        }

        public override void Down()
        {

        }
    }
}

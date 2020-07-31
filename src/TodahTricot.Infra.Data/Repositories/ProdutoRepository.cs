using AutoMapper;
using NHibernate;
using System.Linq;
using TodahTricot.Application.Interfaces.Repositories;
using TodahTricot.Domain.Entities;
using TodahTricot.Infra.Data.DataModels;
using TodahTricot.Infra.Data.Repositories.Base;

namespace TodahTricot.Infra.Data.Repositories
{
    public class ProdutoRepository : Repository<ProdutoModel, ProdutoData>, IProdutoRepository
    {
        private readonly IImagemRepository imagemRepository;

        public ProdutoRepository(IImagemRepository imagemRepository, ISessionFactory sessionFactory, IMapper mapper)
            : base(sessionFactory, mapper)
        {
            this.imagemRepository = imagemRepository;
        }

        public ProdutoModel ObterPorCodigo(string codigo)
        {
            using (var session = sessionFactory.OpenSession())
            {
                var produtoData = session.Query<ProdutoData>().FirstOrDefault(a => a.Codigo == codigo);

                return mapper.Map<ProdutoModel>(produtoData);
            }
        }

        public override ProdutoModel Inserir(ProdutoModel produtoModel)
        {
            if (produtoModel.Imagem != null)
                imagemRepository.Inserir(produtoModel.Imagem);

            return base.Inserir(produtoModel);
        }

        public override ProdutoModel Alterar(ProdutoModel produtoModel)
        {
            if (produtoModel.Imagem != null)
            {
                if (produtoModel.Imagem.Id == 0)
                    imagemRepository.Inserir(produtoModel.Imagem);
                else
                    imagemRepository.Alterar(produtoModel.Imagem);
            }

            return base.Alterar(produtoModel);
        }

        public override void Excluir(int id)
        {
            var produtoModel = ObterPorId(id);
            base.Excluir(id);
            if (produtoModel.Imagem != null)
                imagemRepository.Excluir(produtoModel.Imagem.Id);
        }
    }
}

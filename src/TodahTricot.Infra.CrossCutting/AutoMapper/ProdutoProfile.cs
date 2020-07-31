using AutoMapper;
using TodahTricot.Domain.Entities;
using TodahTricot.Infra.Data.DataModels;

namespace TodahTricot.Infra.CrossCutting.AutoMapper
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<ProdutoData, ProdutoModel>()
               .ConstructUsing(x =>
               {
                   return new ProdutoModel(x == null || x.Id == 0);
               });
        }
    }
}

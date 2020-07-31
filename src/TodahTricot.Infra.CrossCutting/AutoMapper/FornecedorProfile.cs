using AutoMapper;
using TodahTricot.Domain.Entities;
using TodahTricot.Infra.Data.DataModels;

namespace TodahTricot.Infra.CrossCutting.AutoMapper
{
    public class FornecedorProfile : Profile
    {
        public FornecedorProfile()
        {
            CreateMap<FornecedorData, FornecedorModel>()
                .ConstructUsing(x =>
                {
                    return new FornecedorModel(x == null || x.Id == 0);
                });
        }
    }
}

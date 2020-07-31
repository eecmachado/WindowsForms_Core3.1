using AutoMapper;
using TodahTricot.Domain.Entities;
using TodahTricot.Infra.Data.DataModels;

namespace TodahTricot.Infra.CrossCutting.AutoMapper
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<EnderecoData, EnderecoModel>()
                .ConstructUsing(x =>
                {
                    return new EnderecoModel(x == null || x.Id == 0);
                });
        }
    }
}

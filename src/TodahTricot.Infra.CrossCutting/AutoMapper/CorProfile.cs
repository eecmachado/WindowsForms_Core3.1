using AutoMapper;
using TodahTricot.Domain.Entities;
using TodahTricot.Infra.Data.DataModels;

namespace TodahTricot.Infra.CrossCutting.AutoMapper
{
    public class CorProfile : Profile
    {
        public CorProfile()
        {
            CreateMap<CorData, CorModel>()
                .ConstructUsing(x =>
                {
                    return new CorModel(x == null || x.Id == 0);
                });
        }
    }
}

using AutoMapper;
using TodahTricot.Domain.Entities;
using TodahTricot.Infra.Data.DataModels;

namespace TodahTricot.Infra.CrossCutting.AutoMapper
{
    public class DespesaProfile : Profile
    {
        public DespesaProfile()
        {
            CreateMap<DespesaData, DespesaModel>()
               .ConstructUsing(x =>
               {
                   return new DespesaModel(x == null || x.Id == 0);
               });
        }
    }
}

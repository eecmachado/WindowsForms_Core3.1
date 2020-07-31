using AutoMapper;
using TodahTricot.Domain.Entities;
using TodahTricot.Infra.Data.DataModels;

namespace TodahTricot.Infra.CrossCutting.AutoMapper
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<ClienteData, ClienteModel>()
                .ConstructUsing(x =>
                {
                    return new ClienteModel(x == null || x.Id == 0);
                });
        }
    }
}

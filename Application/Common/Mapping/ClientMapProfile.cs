using AutoMapper;
using ConsoleApp1.Entities;
using Contracts.Requests;
using Contracts.Responses;

namespace Application.Common.Mapping
{
    public class ClientMapProfile : Profile
    {
        public ClientMapProfile()
        {
            CreateMap<CreateClientRequest, Client>();

            CreateMap<Client, SingleClientResponse>();

            CreateMap<GetAllClientRequest, GetAllClientResponse>();

            CreateMap<UpdateClientRequest, Client>();
        }
    }
}

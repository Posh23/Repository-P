using AutoMapper;
using Contracts.Requests;
using Contracts.Responses;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Mapping
{
    public class PhotographerMapProfile : Profile
    {
        public PhotographerMapProfile()
        {
            CreateMap<CreatePhotographerRequest, Photographer>();

            CreateMap<Photographer, SinglePhotographerResponse>();

            CreateMap<GetAllPhotographerRequest, GetAllPhotographerResponse>();

            CreateMap<UpdatePhotographerRequest, Photographer>();
        }
    }
}

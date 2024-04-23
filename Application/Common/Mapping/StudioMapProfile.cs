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
    public class StudioMapProfile : Profile
    {
        public StudioMapProfile()
        {
            CreateMap<CreateStudioRequest, Studio>();

            CreateMap<Studio, SingleStudioResponse>();

            CreateMap<GetAllStudioRequest, GetAllStudioResponse>();

            CreateMap<UpdateStudioRequest, Studio>();
        }
    }
}

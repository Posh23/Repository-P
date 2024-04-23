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
    public class MagazineMapProfile : Profile
    {
        public MagazineMapProfile()
        {
            CreateMap<CreateMagazineRequest, Magazine>();

            CreateMap<Magazine, SingleMagazineResponse>();

            CreateMap<GetAllMagazineRequest, GetAllMagazineResponse>();

            CreateMap<UpdateMagazineRequest, Magazine>();
        }
    }
}

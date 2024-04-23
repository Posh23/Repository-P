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
    public class PhotoSessionMapProfile : Profile
    {
        public PhotoSessionMapProfile()
        {
            CreateMap<CreatePhotoSessionRequest, PhotoSession>();

            CreateMap<PhotoSession, SinglePhotoSessionResponse>();

            CreateMap<GetAllPhotoSessionRequest, GetAllPhotoSessionResponse>();

            CreateMap<UpdatePhotoSessionRequest, PhotoSession>();
        }
    }
}

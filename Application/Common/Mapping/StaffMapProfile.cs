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
    public class SatffMapProfile : Profile
    {
        public SatffMapProfile()
        {
            CreateMap<CreateStaffRequest, Staff>();

            CreateMap<Staff, SingleStaffResponse>();

            CreateMap<GetAllStaffRequest, GetAllStaffResponse>();

            CreateMap<UpdateStaffRequest, Staff>();
        }
    }
}

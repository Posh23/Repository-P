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
    public class EquipmentMapProfile : Profile
    {
        public EquipmentMapProfile()
        {
            CreateMap<CreateEquipmentRequest, Equipment>();

            CreateMap<Equipment, SingleEquipmentResponse>();

            CreateMap<GetAllEquipmentRequest, GetAllEquipmentResponse>();

            CreateMap<UpdateEquipmentRequest, Equipment>();
        }
    }
}

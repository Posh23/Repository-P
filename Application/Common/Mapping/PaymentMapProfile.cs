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
    public class PaymentMapProfile : Profile
    { 
        public PaymentMapProfile()
        {
            CreateMap<CreatePaymentRequest, Payment>();

            CreateMap<Payment, SinglePaymentResponse>();

            CreateMap<GetAllPaymentRequest, GetAllPaymentResponse>();

            CreateMap<UpdatePaymentRequest, Payment>();
        }
    }
}

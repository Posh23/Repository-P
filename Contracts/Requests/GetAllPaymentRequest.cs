using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Requests
{
    public class GetAllPaymentRequest
    {
        public IEnumerable<Payment> Items { get; set; } = Enumerable.Empty<Payment>();
    }
}

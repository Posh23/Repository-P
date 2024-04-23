using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Responses
{
    public class GetAllPaymentResponse
    {
        public IEnumerable<SinglePaymentResponse> Items { get; set; } = Enumerable.Empty<SinglePaymentResponse>();
    }
}

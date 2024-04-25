using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Responses
{
    public class GetAllClientResponse
    {
        public IEnumerable<SingleClientResponse> Items { get; set; } = Enumerable.Empty<SingleClientResponse>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Responses
{
    public class GetAllStudioResponse
    {
        public IEnumerable<SingleStudioResponse> Items { get; set; } = Enumerable.Empty<SingleStudioResponse>();
    }
}

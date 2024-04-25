using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Responses
{
    public class GetAllMagazineResponse
    {
        public IEnumerable<SingleMagazineResponse> Items { get; set; } = Enumerable.Empty<SingleMagazineResponse>();
    }
}

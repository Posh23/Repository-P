using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Responses
{
    public class GetAllPhotoSessionResponse
    {
        public IEnumerable<SinglePhotoSessionResponse> Items { get; set; } = Enumerable.Empty<SinglePhotoSessionResponse>();
    }
}

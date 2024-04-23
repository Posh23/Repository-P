using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Responses
{
    public class GetAllEquipmentResponse
    {
        public IEnumerable<SingleEquipmentResponse> Items { get; set; } = Enumerable.Empty<SingleEquipmentResponse>();
    }
}

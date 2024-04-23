using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Requests
{
    public class GetAllEquipmentRequest
    {
        public IEnumerable<Equipment> Items { get; set; } = Enumerable.Empty<Equipment>();
    }
}

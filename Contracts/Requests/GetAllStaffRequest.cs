using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Requests
{
    public class GetAllStaffRequest
    {
        public IEnumerable<Staff> Items { get; set; } = Enumerable.Empty<Staff>();
    }
}

using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Responses
{
    public class SingleStaffResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Position { get; set; }

    //  public Studio Studios { get; set; }
        public Guid StudioId { get; set; }
    }
}

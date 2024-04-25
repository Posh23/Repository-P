using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Responses
{
    public class SingleEquipmentResponse
    {
        public Guid Id { get; set; }
        public string Type { get; set; }

        public string Brand { get; set; }

        public string Condition { get; set; }

        public bool Availability { get; set; }

        //public virtual ICollection<Studio> Studios { get; set; }
       // public virtual ICollection<Magazine> Magazines { get; set; }
    }
}

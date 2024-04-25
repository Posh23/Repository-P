using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Requests
{
    public class UpdateStudioRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

     //   public Equipment Equipments { get; set; }
        public Guid EquipmentId { get; set; }
      //  public virtual ICollection<Staff> Staffs { get; set; }
    }
}

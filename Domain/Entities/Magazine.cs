using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Magazine : BaseEntity

    {

        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string Type { get; set; } = string.Empty;

        public PhotoSession? PhotoSession { get; set; }
        public Guid PhotoSessionId { get; set; }

        public Equipment? Equipment { get; set; }
        public Guid EquiupmentId { get; set; }
        public Guid EquipmentId { get; set; }
    }
}

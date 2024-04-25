using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Contracts.Requests
{
    public class UpdateStaffRequest
    {
        [JsonIgnore]

        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Position { get; set; }

       // public Studio Studios { get; set; }
        public Guid StudioId { get; set; }
    }
}

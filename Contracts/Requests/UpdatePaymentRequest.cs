using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Contracts.Requests
{
    public class UpdatePaymentRequest
    {
        [JsonIgnore]

        public Guid Id { get; set; }
        public float Amount { get; set; }

        public string Date { get; set; }

       // public virtual ICollection<PhotoSession> PhotoSessions { get; set; }
    }
}

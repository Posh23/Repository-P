using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Requests
{
    public class UpdatePhotographerRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public string Specialty { get; set; }
       // public PhotoSession PhotoSessions { get; set; }
        public Guid PhotoSessionId { get; set; }
    }
}

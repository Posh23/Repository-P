using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Requests
{
    public class GetAllPhotoSessionRequest
    {
        public IEnumerable<PhotoSession> Items { get; set; } = Enumerable.Empty<PhotoSession>();
    }
}

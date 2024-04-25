using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Requests
{
    public class GetAllPhotographerRequest
    {
        public IEnumerable<Photographer> Items { get; set; } = Enumerable.Empty<Photographer>();
    }
}

﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Requests
{
    public class CreatePhotoSessionRequest
    {
      //  public Guid Id { get; set; }
        public string Date { get; set; }

        public int Duration { get; set; }

       // public virtual ICollection<Photographer> Photographers { get; set; }

       // public virtual ICollection<Magazine> Magazines { get; set; }
    }
}

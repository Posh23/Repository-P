using System.Collections;

namespace Domain.Entities;

public class PhotoSession : BaseEntity
{
    public Guid Id { get; set; }
    public string Date { get; set; }

    public int Duration { get; set; }

    public virtual ICollection<Photographer> Photographers { get; set; }
 
    public virtual ICollection<Magazine> Magazines { get; set; }
}
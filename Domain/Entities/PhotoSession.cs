using System.Collections;

namespace ConsoleApp1.Entities;

public class PhotoSession : BaseEntity
{

    public string Date { get; set; }

    public int Duration { get; set; }

    public virtual ICollection<Photographer> Photographers { get; set; }
 
    public virtual ICollection<Magazine> Magazines { get; set; }
}
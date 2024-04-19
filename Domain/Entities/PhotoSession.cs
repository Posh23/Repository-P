using System.Collections;

namespace ConsoleApp1.Entities;

public class PhotoSession : BaseEntity
{

    public string Date { get; set; }

    public int Duration { get; set; }

    public Photographer Photographer { get; set; }

    public ICollection Client { get; set; }
    public ICollection Payment { get; set; }
    public object Magazines { get; set; }
}
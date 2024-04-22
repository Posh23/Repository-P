using System.Collections;

namespace ConsoleApp1.Entities;

public class Client : BaseEntity
{

    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public virtual ICollection<PhotoSession> PhotoSessions  { get; set; }
 
}
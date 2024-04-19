namespace ConsoleApp1.Entities;

public class Payment : BaseEntity
{

    public float Amount { get; set; }

    public  string Date { get; set; }

    public PhotoSession PhotoSessions { get; set; }
}
namespace ConsoleApp1.Entities;

public class Payment
{
    public Guid Id { get; set; }

    public float Amount { get; set; }

    public  string Date { get; set; }

    public PhotoSession Session { get; set; }
}
namespace ConsoleApp1.Entities;

public class PhotoSession
{
    public Guid Id { get; set; }

    public string Date { get; set; }

    public int Duration { get; set; }

    public Photographer Photographer { get; set; }

    public Client Client { get; set; }
}
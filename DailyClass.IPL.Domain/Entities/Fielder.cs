namespace DailyClass.IPL.Domain.Entities;

public class Fielder
{
    public int Id { get; set; }
    public Player? Player { get; set; }
    public bool Substitute { get; set; }
}

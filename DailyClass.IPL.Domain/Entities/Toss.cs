namespace DailyClass.IPL.Domain.Entities;

public class Toss
{
    public int Id { get; set; }
    public string? Decision { get; set; }
    public Team? Winner { get; set; }
}

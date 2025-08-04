namespace DailyClass.IPL.Domain.Entities;

public class Review
{
    public int Id { get; set; }
    public Team? ByTeam { get; set; }
    public Official? Umpire { get; set; }
    public Player? Batter { get; set; }
    public string? Decision { get; set; }
    public string? Type { get; set; }
}

namespace DailyClass.IPL.Domain.Entities;

public class Delivery
{
    public int Id { get; set; }
    public int BallNumber { get; set; }
    public Player? Batter { get; set; }
    public Player? Bowler { get; set; }
    public Player? NonStriker { get; set; }
    public int RunsBatter { get; set; }
    public int RunsExtras { get; set; }
    public int RunsTotal { get; set; }
    public int? ExtrasWides { get; set; }
    public int? ExtrasLegByes { get; set; }
    public int? ExtrasNoBalls { get; set; }
    public int? ExtrasByes { get; set; }
    public ICollection<Wicket>? Wickets { get; set; }
    public Review? Review { get; set; }
}

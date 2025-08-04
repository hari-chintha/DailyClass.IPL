namespace DailyClass.IPL.Domain.Entities;

public class Outcome
{
    public int Id { get; set; }
    public Team? Winner { get; set; }
    public int? ByWickets { get; set; }
    public int? ByRuns { get; set; }
}

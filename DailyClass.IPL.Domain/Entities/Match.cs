namespace DailyClass.IPL.Domain.Entities;

public class Match
{
    public int Id { get; set; }
    public string? DataVersion { get; set; }
    public DateTime Created { get; set; }
    public int Revision { get; set; }
    public int BallsPerOver { get; set; }
    public string? City { get; set; }
    public DateTime Date { get; set; }
    public string? EventName { get; set; }
    public int MatchNumber { get; set; }
    public string? Gender { get; set; }
    public string? MatchType { get; set; }
    public int Overs { get; set; }
    public string? Season { get; set; }
    public string? TeamType { get; set; }
    public string? Venue { get; set; }
    public Toss? Toss { get; set; }
    public Outcome? Outcome { get; set; }
    public ICollection<Team>? Teams { get; set; }
    public ICollection<Official>? Officials { get; set; }
    public ICollection<PlayerOfMatch>? PlayerOfMatch { get; set; }
    public ICollection<Inning>? Innings { get; set; }
}

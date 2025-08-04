namespace DailyClass.IPL.Domain.Entities;

public class Inning
{
    public int Id { get; set; }
    public Team? Team { get; set; }
    public ICollection<Over>? Overs { get; set; }
    public ICollection<Powerplay>? Powerplays { get; set; }
}

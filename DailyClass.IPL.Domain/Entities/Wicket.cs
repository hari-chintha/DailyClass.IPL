namespace DailyClass.IPL.Domain.Entities;

public class Wicket
{
    public int Id { get; set; }
    public Player? PlayerOut { get; set; }
    public ICollection<Fielder>? Fielders { get; set; }
    public string? Kind { get; set; }
    public bool Substitute { get; set; }
}

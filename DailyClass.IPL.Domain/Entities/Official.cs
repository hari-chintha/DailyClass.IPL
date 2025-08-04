namespace DailyClass.IPL.Domain.Entities;

public class Official
{
    public int Id { get; set; }
    public string? Type { get; set; } // umpire, tv_umpire, match_referee, reserve_umpire
    public Player? Player { get; set; }
}

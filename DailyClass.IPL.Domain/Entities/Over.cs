namespace DailyClass.IPL.Domain.Entities;

public class Over
{
    public int Id { get; set; }
    public int OverNumber { get; set; }
    public ICollection<Delivery>? Deliveries { get; set; }
}

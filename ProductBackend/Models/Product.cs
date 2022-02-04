namespace ProductBackend.Models;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public double UnitPrice { get; set; }
    public int Rating { get; set; }
    public bool Active { get; set; }
}

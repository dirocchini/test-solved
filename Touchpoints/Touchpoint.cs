using Microsoft.EntityFrameworkCore;

public class Touchpoint
{
    public Touchpoint()
    {
        DateCreated = DateTime.Now;
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime DateCreated { get; set; }
}

public class ApplicationDbContext : DbContext
{
    public DbSet<Touchpoint> Touchpoints { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }
}

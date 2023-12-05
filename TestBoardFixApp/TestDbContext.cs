
namespace TestBoardFixApp;

public class TestDbContext:DbContext
{
    public DbSet<FixFileData> FixFileData { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connStr = "Server=localhost;Port=5432;UserId=postgres;Password=1234;Database=postgres";
        optionsBuilder.UseNpgsql(connStr);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
    }
}


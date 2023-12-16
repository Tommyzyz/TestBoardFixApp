
namespace TestBoardFixApp;

public class TestDbContext:DbContext
{
    public DbSet<FixFileData> FixFileData { get; set; }
    public DbSet<FixedFileData> FixedFileData { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connStr = ConfigurationManager.ConnectionStrings["TestDbConnectString"].ToString();
        optionsBuilder.UseNpgsql(connStr);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
    }
}


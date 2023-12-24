namespace TestBoardFixEFCoreLib;

public class TestDbContext : DbContext
{
    public TestDbContext(DbContextOptions<TestDbContext> options):base(options) 
    {}

    public DbSet<FixFileData> FixFileData { get; set; }
    public DbSet<FixedFileData> FixedFileData { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<TestDbContext>
{
    public TestDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<TestDbContext>();
        //string connStr = ConfigurationManager.ConnectionStrings["TestDbConnectString"].ToString();
        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;UserId=postgres;Password=1234;Database=postgres");

        return new TestDbContext(optionsBuilder.Options);
    }
}

namespace TestBoardFixEFCoreLib;

public class FixFileConfig : IEntityTypeConfiguration<FixFileData>
{
    public void Configure(EntityTypeBuilder<FixFileData> builder)
    {
        builder.ToTable("Table_FixFileData");
        builder.Property(e => e.TestMachingType).IsRequired();
        builder.Property(e => e.TestMachingNum).HasMaxLength(50).IsRequired();

    }
}


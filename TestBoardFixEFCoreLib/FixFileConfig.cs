namespace TestBoardFixEFCoreLib;

public class FixFileConfig : IEntityTypeConfiguration<FixFileData>
{
    public void Configure(EntityTypeBuilder<FixFileData> builder)
    {
        builder.ToTable("Table_FixFileData");
        builder.Property(e => e.TestMachineType).IsRequired();
        builder.Property(e => e.TestMachineNum).HasMaxLength(50).IsRequired();

    }
}


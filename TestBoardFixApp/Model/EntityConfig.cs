



using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TestBoardFixApp.Model;

public class FixFileConfig : IEntityTypeConfiguration<FixFileData>
{
    public void Configure(EntityTypeBuilder<FixFileData> builder)
    {
        builder.ToTable("T_FixFileData");
        builder.Property(e => e.TestMachingType).IsRequired();
        builder.Property(e=>e.TestMachingNum).HasMaxLength(50).IsRequired();

    }
}

public class FixedFileConfig : IEntityTypeConfiguration<FixedFileData>
{
    public void Configure(EntityTypeBuilder<FixedFileData> builder)
    {
        builder.ToTable("T_FixedFileData");
        builder.Property(e => e.RegisteredPerson).IsRequired();
        builder.Property(e=> e.TestingMethod).IsRequired();
        builder.Property(e=>e.FixdMethod).IsRequired();
    }
}
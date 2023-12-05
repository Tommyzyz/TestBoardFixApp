



using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TestBoardFixApp.Model;

public class EntityConfig : IEntityTypeConfiguration<FixFileData>
{
    public void Configure(EntityTypeBuilder<FixFileData> builder)
    {
        builder.ToTable("T_FixFileData");
        builder.Property(e => e.TestMachingType).IsRequired();
        builder.Property(e=>e.TestMachingNum).HasMaxLength(50).IsRequired();

    }
}


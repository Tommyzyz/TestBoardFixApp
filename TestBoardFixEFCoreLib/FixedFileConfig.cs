

namespace TestBoardFixEFCoreLib
{
    public class FixedFileConfig : IEntityTypeConfiguration<FixedFileData>
    {
        public void Configure(EntityTypeBuilder<FixedFileData> builder)
        {
            builder.ToTable("Table_FixedFileData");
            builder.Property(e => e.RegisteredPerson).IsRequired();
            builder.Property(e => e.TestingMethod).IsRequired();
            builder.Property(e => e.FixdMethod).IsRequired();
            builder.HasOne<FixFileData>(e => e.FixFileData).WithOne(e => e.FixedFileData).HasForeignKey<FixedFileData>(x => x.FixFileDataID);
        }
    }
}

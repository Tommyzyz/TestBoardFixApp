using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBoardFixApp.Model
{
    public class FixedFileConfig : IEntityTypeConfiguration<FixedFileData>
    {
        public void Configure(EntityTypeBuilder<FixedFileData> builder)
        {
            builder.ToTable("T_FixedFileData");
            builder.Property(e => e.RegisteredPerson).IsRequired();
            builder.Property(e => e.TestingMethod).IsRequired();
            builder.Property(e => e.FixdMethod).IsRequired();
            //builder.HasOne<FixFileData>(e => e.FixFileData).WithOne(e => e.FixedFileData).IsRequired();
        }
    }
}

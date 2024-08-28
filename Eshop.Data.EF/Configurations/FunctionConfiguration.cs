using Eshop.Data.EF.Extensions;
using Eshop.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eshop.Data.EF.Configurations
{
    public class FunctionConfiguration : DbEntityConfiguration<Function>
    {
        public override void Configure(EntityTypeBuilder<Function> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).IsRequired()
                .HasMaxLength(128).IsUnicode(false);
            // etc.
        }
    }
}
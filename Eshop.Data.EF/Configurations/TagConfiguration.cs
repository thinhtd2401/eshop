using Eshop.Data.EF.Extensions;
using Eshop.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eshop.Data.EF.Configurations
{
    public class TagConfiguration : DbEntityConfiguration<Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(50)
                .IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }
}
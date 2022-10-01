using ItEmperor.Product.Classifications;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Product.Dal.Configurations.Classifications;

public class ProductCategoryRollupConfiguration : IEntityTypeConfiguration<ProductCategoryRollup>
{
    public void Configure(EntityTypeBuilder<ProductCategoryRollup> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Parent)
            .WithMany(x=>x.ProductCategoryParentsRollup)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.Child)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);
    }
}
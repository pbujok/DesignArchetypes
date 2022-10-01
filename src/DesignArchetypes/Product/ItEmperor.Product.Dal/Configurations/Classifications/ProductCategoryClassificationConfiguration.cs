using ItEmperor.Product.Classifications;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Product.Dal.Configurations.Classifications;

public class ProductCategoryClassificationConfiguration : IEntityTypeConfiguration<ProductCategoryClassification>
{
    public void Configure(EntityTypeBuilder<ProductCategoryClassification> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Product)
            .WithMany(x => x.ProductCategoryClassification)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.ProductCategory)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);
    }
}
using ItEmperor.Product.Classifications;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Product.Dal.Configurations.Classifications;

public abstract class ProductCategoryConfigurationBase<T> : IEntityTypeConfiguration<T>
    where T : ProductCategory
{
    public void Configure(EntityTypeBuilder<T> builder)
    {
        builder.ToTable("ProductCategory");
        ConfigureEntity(builder);
    }

    protected abstract void ConfigureEntity(EntityTypeBuilder<T> builder);
}

public class ProductCategoryConfiguration : ProductCategoryConfigurationBase<ProductCategory>
{
    protected override void ConfigureEntity(EntityTypeBuilder<ProductCategory> builder)
    {
        builder.HasKey(x => x.Id);
    }
}
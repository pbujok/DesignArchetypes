using ItEmperor.Product.Classifications;
using ItEmperor.Product.Classifications.Category;
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

public class GoodCategoryConfiguration : ProductCategoryConfigurationBase<GoodsCategory>
{
    protected override void ConfigureEntity(EntityTypeBuilder<GoodsCategory> builder)
    {
    }
}

public class ServiceCategoryConfiguration : ProductCategoryConfigurationBase<ServicesCategory>
{
    protected override void ConfigureEntity(EntityTypeBuilder<ServicesCategory> builder)
    {
    }
}
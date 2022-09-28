using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Product.Dal.Configurations;

public abstract class ProductConfigurationBase<T> : IEntityTypeConfiguration<T>
    where T : Product
{
    public void Configure(EntityTypeBuilder<T> builder)
    {
        builder.ToTable("Product");
        ConfigureEntity(builder);
    }

    protected abstract void ConfigureEntity(EntityTypeBuilder<T> builder);
}

public class ProductConfiguration : ProductConfigurationBase<Product>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(x => x.Id);
    }
}
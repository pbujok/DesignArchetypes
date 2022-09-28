using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Product.Dal.Configurations;

public class GoodConfiguration : ProductConfigurationBase<Good>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Good> builder)
    {
    }
}
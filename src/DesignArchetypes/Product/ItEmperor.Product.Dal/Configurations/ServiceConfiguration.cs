using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Product.Dal.Configurations;

public class ServiceConfiguration : ProductConfigurationBase<Service>
{
    protected  override void ConfigureEntity(EntityTypeBuilder<Service> builder)
    {
    }
}
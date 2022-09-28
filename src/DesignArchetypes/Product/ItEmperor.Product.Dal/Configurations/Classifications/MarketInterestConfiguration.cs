using ItEmperor.Product.Classifications;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Product.Dal.Configurations.Classifications;

public class MarketInterestConfiguration : IEntityTypeConfiguration<MarketInterest>
{
    public void Configure(EntityTypeBuilder<MarketInterest> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.ProductCategory)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);
    }
}
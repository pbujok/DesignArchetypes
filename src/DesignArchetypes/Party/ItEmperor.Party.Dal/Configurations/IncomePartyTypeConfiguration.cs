using ItEmperor.Party.Classifications.Organizations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Party.Tests.Configurations;

public class IncomePartyTypeConfiguration : IEntityTypeConfiguration<IncomePartyType>
{
    public void Configure(EntityTypeBuilder<IncomePartyType> builder)
    {
        builder.ToTable("PartyType");

        builder.OwnsOne(x => x.IncomeFrom);

        builder.OwnsOne(x => x.IncomeTo);
    }
}
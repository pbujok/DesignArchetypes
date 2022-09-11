using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Party.Tests.Configurations;

public class OrganizationConfiguration : PartyConfigurationBase<Organization>
{
    public override void Configure(EntityTypeBuilder<Organization> builder)
    {
        base.Configure(builder);
        builder.Property(x => x.TaxId)
            .HasConversion(x => x.Value, val => new TaxId(val));
    }
}
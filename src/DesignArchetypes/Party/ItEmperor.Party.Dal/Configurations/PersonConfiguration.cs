using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Party.Tests.Configurations;

public class PersonConfiguration : PartyConfigurationBase<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        base.Configure(builder);

        builder.ToTable("Party")
            .HasDiscriminator(x => x.PartyType)
            .HasValue<Person>(1)
            .HasValue<Organization>(2);

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasConversion(x => x.Value, guid => new PartyId(guid));

    }
}
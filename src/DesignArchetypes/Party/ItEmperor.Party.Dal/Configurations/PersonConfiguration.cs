using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Party.Tests.Configurations;

public class PersonConfiguration : PartyConfigurationBase<Person.Person>
{
    public void Configure(EntityTypeBuilder<Person.Person> builder)
    {
        base.Configure(builder);

        builder.ToTable("Party")
            .HasDiscriminator(x => x.PartyType)
            .HasValue<Person.Person>(1)
            .HasValue<Organization.Organization>(2);

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasConversion(x => x.Value, guid => new PartyId(guid));

        builder.OwnsMany(x => x.Addresses, navigationBuilder => { navigationBuilder.HasKey(x => x.Id); });

        builder.OwnsMany(x => x.PositionAssignments, navigationBuilder => { navigationBuilder.HasKey(x => x.Id); });
    }
}
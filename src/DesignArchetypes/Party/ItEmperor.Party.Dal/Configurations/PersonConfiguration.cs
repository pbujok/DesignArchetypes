using ItEmperor.Party.Persons;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Party.Tests.Configurations;

public class PersonConfiguration : PartyConfigurationBase<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        base.Configure(builder);
        
        builder.OwnsMany(x => x.Addresses, navigationBuilder => { navigationBuilder.HasKey(x => x.Id); });
    }
}
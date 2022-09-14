using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Party.Tests.Configurations;

public class PersonConfiguration : PartyConfigurationBase<Person.Person>
{
    public void Configure(EntityTypeBuilder<Person.Person> builder)
    {
        base.Configure(builder);
        
        builder.OwnsMany(x => x.Addresses, navigationBuilder => { navigationBuilder.HasKey(x => x.Id); });
    }
}
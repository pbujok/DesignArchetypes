using ItEmperor.Party.Employment.Simple;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Party.Tests.Configurations;

public class PersonConfiguration : PartyConfigurationBase<Person.Person>
{
    public void Configure(EntityTypeBuilder<Person.Person> builder)
    {
        base.Configure(builder);
        
        builder.OwnsMany(x => x.Addresses, navigationBuilder => { navigationBuilder.HasKey(x => x.Id); });

        builder.OwnsMany(x => x.PositionAssignments, navigationBuilder => { navigationBuilder.HasKey(x => x.Id); });
    }
}

public class SimpleEmploymentConfiguration : IEntityTypeConfiguration<SimpleEmployment>
{
    public void Configure(EntityTypeBuilder<SimpleEmployment> builder)
    {
        builder.HasOne(x => x.Person)
            .WithMany(x=>x.Employments)
            .OnDelete(DeleteBehavior.NoAction);
        
        builder.HasOne(x => x.Organization)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);
    }
}
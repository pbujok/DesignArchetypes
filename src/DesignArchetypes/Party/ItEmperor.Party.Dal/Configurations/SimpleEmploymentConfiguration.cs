using ItEmperor.Party.Organizations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Party.Tests.Configurations;

public class SimpleEmploymentConfiguration : IEntityTypeConfiguration<SimpleEmployment>
{
    public void Configure(EntityTypeBuilder<SimpleEmployment> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Organization)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);
        
        builder.HasOne(x => x.Person)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);
    }
}
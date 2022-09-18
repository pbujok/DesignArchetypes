using ItEmperor.Party.Relationships;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Party.Tests.Configurations.Relationships;

public class PartyRelationshipTypeConfiguration : IEntityTypeConfiguration<PartyRelationshipType>
{
    public void Configure(EntityTypeBuilder<PartyRelationshipType> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.From)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);
        
        builder.HasOne(x => x.To)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);
    }
}

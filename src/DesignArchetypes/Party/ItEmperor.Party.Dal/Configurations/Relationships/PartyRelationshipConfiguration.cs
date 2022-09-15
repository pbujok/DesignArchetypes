using ItEmperor.Party.Relationships;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Party.Tests.Configurations.Relationships;

public class PartyRelationshipConfiguration : IEntityTypeConfiguration<PartyRelationship>
{
    public void Configure(EntityTypeBuilder<PartyRelationship> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.PartyA)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);
        
        builder.HasOne(x => x.PartyB)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);
    }
}

public abstract class PartyRelationshipConfigrationBase<TParty> : IEntityTypeConfiguration<TParty>
    where TParty : PartyRelationship
{
    public virtual void Configure(EntityTypeBuilder<TParty> builder)
    {
        builder.ToTable("PartyRelationship");
    }
}
using ItEmperor.Party.Relationship;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Party.Tests.Configurations;

public class PartyRelationshipConfiguration : IEntityTypeConfiguration<PartyRelationship>
{
    public void Configure(EntityTypeBuilder<PartyRelationship> builder)
    {
        builder.HasKey(x => x.Id);
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
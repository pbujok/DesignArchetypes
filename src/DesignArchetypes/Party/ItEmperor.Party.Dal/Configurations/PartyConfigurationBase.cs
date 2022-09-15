using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Party.Tests.Configurations;

public class PartyConfiguration : IEntityTypeConfiguration<Party>
{
    public void Configure(EntityTypeBuilder<Party> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasConversion(x => x.Value, guid => new PartyId(guid));
        
        builder.OwnsMany(x => x.TelephoneNumbers);
    }
}

public class PartyConfigurationBase<TParty> : IEntityTypeConfiguration<TParty>
    where TParty : Party
{
    public virtual void Configure(EntityTypeBuilder<TParty> builder)
    {
        builder.ToTable("Party");
    }
}
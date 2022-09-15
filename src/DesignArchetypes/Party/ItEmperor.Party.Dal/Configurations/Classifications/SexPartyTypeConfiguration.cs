using ItEmperor.Party.Classifications.Persons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Party.Tests.Configurations.Classifications;

public class SexPartyTypeConfiguration : IEntityTypeConfiguration<SexPartyType>
{
    public void Configure(EntityTypeBuilder<SexPartyType> builder)
    {
        builder.ToTable("PartyType");
    }
}
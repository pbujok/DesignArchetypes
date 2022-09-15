using ItEmperor.Party.Classifications;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Party.Tests.Configurations.Classifications;

public class PartyClassificationConfiguration : IEntityTypeConfiguration<PartyClassification>
{
    public void Configure(EntityTypeBuilder<PartyClassification> builder)
    {
        builder.HasOne(x => x.Type)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.Party)
            .WithMany(x => x.PartyClassifications);
    }
}
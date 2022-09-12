using ItEmperor.Party.Employment.Complex;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Party.Tests.Configurations;

public class PositionAssignmentConfiguration : IEntityTypeConfiguration<PositionAssignment>
{
    public void Configure(EntityTypeBuilder<PositionAssignment> builder)
    {
        builder.HasKey(x => x.Id);
    }
}
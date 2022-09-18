using ItEmperor.Party.Relationships;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Party.Tests.Configurations.Relationships;

public class PositionAssignmentConfiguration : PartyRelationshipConfigrationBase<PositionAssignmentEmployment>
{
    public void Configure(EntityTypeBuilder<PositionAssignmentEmployment> builder)
    {
        base.Configure(builder);
    }
}
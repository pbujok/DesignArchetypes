using ItEmperor.Party.Relationships.Employments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace ItEmperor.Party.Tests.Configurations;

public class PositionAssignmentConfiguration : PartyRelationshipConfigrationBase<PositionAssignmentEmployment>
{
    public void Configure(EntityTypeBuilder<PositionAssignmentEmployment> builder)
    {
        base.Configure(builder);
    }
}
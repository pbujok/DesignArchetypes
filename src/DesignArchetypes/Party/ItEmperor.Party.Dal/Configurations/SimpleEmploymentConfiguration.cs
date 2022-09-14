using ItEmperor.Party.Relationship.Employment;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Party.Tests.Configurations;

public class SimpleEmploymentConfiguration : PartyRelationshipConfigrationBase<SimpleEmployment>
{
    public void Configure(EntityTypeBuilder<SimpleEmployment> builder)
    {
        base.Configure(builder);
    }
}
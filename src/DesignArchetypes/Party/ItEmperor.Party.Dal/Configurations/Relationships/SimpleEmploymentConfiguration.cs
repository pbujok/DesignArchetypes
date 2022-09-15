﻿using ItEmperor.Party.Relationships.Employments;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Party.Tests.Configurations.Relationships;

public class SimpleEmploymentConfiguration : PartyRelationshipConfigrationBase<SimpleEmployment>
{
    public void Configure(EntityTypeBuilder<SimpleEmployment> builder)
    {
        base.Configure(builder);
    }
}
using ItEmperor.Party.Roles;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Party.Tests.Configurations.Roles;

public class PersonPartyRoleConfiguration : PartyRoleConfigurationBase<PersonPartyRole>
{
    protected override void ConfigureDerivedType(EntityTypeBuilder<PersonPartyRole> builder)
    {
    }
}

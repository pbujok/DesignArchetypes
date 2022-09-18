using ItEmperor.Party.Roles;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperor.Party.Tests.Configurations.Roles;

public class OrganizationPartyRoleConfiguration : PartyRoleConfigurationBase<OrganizationPartyRole>
{
    protected override void ConfigureDerivedType(EntityTypeBuilder<OrganizationPartyRole> builder)
    {
    }
}
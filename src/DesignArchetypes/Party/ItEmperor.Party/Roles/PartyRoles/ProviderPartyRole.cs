using ItEmperor.Party.Roles.RoleTypes;

namespace ItEmperor.Party.Roles.PartyRoles;

public class ProviderPartyRole : OrganizationPartyRole
{
    protected ProviderPartyRole()
    {
    }

    public ProviderPartyRole(DateTimeOffset dateFrom, DateTimeOffset? dateTo, Party party) : base(
        dateFrom, dateTo, party, PartyRoleType.Provider)
    {
    }
}
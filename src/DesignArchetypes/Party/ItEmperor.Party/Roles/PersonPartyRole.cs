using ItEmperor.Party.Roles.RoleTypes;

namespace ItEmperor.Party.Roles;

public class PersonPartyRole : PartyRole
{
    protected PersonPartyRole()
    {
    }

    public PersonPartyRole(DateTimeOffset dateFrom, DateTimeOffset? dateTo, Party party, PartyRoleType roleType) : base(dateFrom, dateTo, party, roleType)
    {
    }
}
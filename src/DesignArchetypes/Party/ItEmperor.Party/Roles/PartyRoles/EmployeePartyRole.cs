using ItEmperor.Party.Roles.RoleTypes;

namespace ItEmperor.Party.Roles.PartyRoles;

public class EmployeePartyRole : PersonPartyRole
{
    protected EmployeePartyRole()
    {
    }

    public EmployeePartyRole(DateTimeOffset dateFrom, DateTimeOffset? dateTo, Party party, PartyRoleType roleType) :
        base(dateFrom, dateTo, party, roleType)
    {
    }
}
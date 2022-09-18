using ItEmperor.Party.Roles.RoleTypes;

namespace ItEmperor.Party.Roles.PartyRoles;

public class PartyRole
{
    public Guid Id { get; init; }

    public DateTimeOffset DateFrom { get; private set; }

    public DateTimeOffset? DateTo { get; private set; }

    public Party Party { get; private set; }

    public PartyRoleType RoleType { get; private set; }

    protected PartyRole()
    {
    }

    public PartyRole(DateTimeOffset dateFrom, DateTimeOffset? dateTo, Party party, PartyRoleType roleType)
    {
        Id = Guid.NewGuid();
        DateFrom = dateFrom;
        DateTo = dateTo;
        Party = party;
        RoleType = roleType;
    }
}
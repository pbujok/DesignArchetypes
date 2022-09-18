using ItEmperor.Party.Classifications;
using ItEmperor.Party.Roles;
using ItEmperor.Party.Roles.PartyRoles;
using ItEmperor.Party.Roles.RoleTypes;

namespace ItEmperor.Party;

public abstract class Party
{
    protected Party()
    {
    }

    public Party(PartyId id, string name)
    {
        Id = id;
        Name = name;
    }

    public PartyId Id { get; }

    public string Name { get; }

    public ICollection<TelephoneNumber> TelephoneNumbers { get; private set; } = new List<TelephoneNumber>();

    public ICollection<PartyClassification> PartyClassifications { get; private set; } =
        new List<PartyClassification>();

    public ICollection<PartyRole> PartyRoles { get; private set; } = new List<PartyRole>();

    public void AddTelephone(string name, string telephone)
    {
        TelephoneNumbers.Add(new TelephoneNumber(name, telephone));
    }
    
    public void AddRole(DateTimeOffset dateFrom, DateTimeOffset? dateTo, PartyRoleType partyRoleType)
    {
        PartyRoles.Add(new PartyRole(dateFrom, dateTo, this, partyRoleType));
    }
}
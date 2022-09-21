using ItEmperor.Party.Classifications;
using ItEmperor.Party.Contact;
using ItEmperor.Party.Contact.ContactMechanisms;
using ItEmperor.Party.Roles;
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
    
    public ICollection<PartyClassification> PartyClassifications { get; private set; } =
        new List<PartyClassification>();

    public ICollection<PartyContactMechanism> PartyContactMechanisms { get; private set; } =
        new List<PartyContactMechanism>();

    public ICollection<PartyRole> PartyRoles { get; private set; } = new List<PartyRole>();

    public void AddTelephone(string name, string telephone, DateTimeOffset from, DateTimeOffset? to = null)
    {
        var partyContactMechanism = new PartyContactMechanism(new TelephoneContactMechanism(name, telephone), this, from, to);
        PartyContactMechanisms.Add(partyContactMechanism);
    }
    
    public void AddEmail(string email, DateTimeOffset from, DateTimeOffset? to = null, string? name = null)
    {
        var partyContactMechanism = new PartyContactMechanism(new EmailContactMechanism(name, email), this, from, to);
        PartyContactMechanisms.Add(partyContactMechanism);
    }

    public void AddRole(DateTimeOffset dateFrom, DateTimeOffset? dateTo, PartyRoleType partyRoleType)
    {
        PartyRoles.Add(new PartyRole(dateFrom, dateTo, this, partyRoleType));
    }
}
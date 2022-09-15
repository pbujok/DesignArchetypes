using ItEmperor.Party.Classifications.Organizations;

namespace ItEmperor.Party.Classifications.Persons;

public class SexPartyType : PartyType
{
    public static SexPartyType Male => new SexPartyType("Male")
    {
        Id = new Guid("de5dab31-bddb-4168-9dc1-bfa958cfe9c0")
    };

    public static SexPartyType Female => new SexPartyType("Female")
    {
        Id = new Guid("55a85103-e18b-4b3d-adb6-dab0970e1b2f")
    };

    protected SexPartyType()
    {
    }

    public SexPartyType(string description) : base(description)
    {
    }
}
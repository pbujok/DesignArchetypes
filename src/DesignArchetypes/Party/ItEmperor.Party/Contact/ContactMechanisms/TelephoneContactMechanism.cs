namespace ItEmperor.Party.Contact.ContactMechanisms;

public class TelephoneContactMechanism : ContactMechanism
{
    public string TelephoneNumber { get; private set; }

    public TelephoneContactMechanism(string name, string telephoneNumber) : base(ContactMechanismType.TelephoneNumber, name)
    {
        TelephoneNumber = telephoneNumber;
    }
}
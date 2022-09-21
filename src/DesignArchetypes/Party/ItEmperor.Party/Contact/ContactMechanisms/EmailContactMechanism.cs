namespace ItEmperor.Party.Contact.ContactMechanisms;

public class EmailContactMechanism : ContactMechanism
{
    public string EmailAddress { get; private set; }

    public EmailContactMechanism(string name, string emailAddress) : base(ContactMechanismType.EMail, name)
    {
        EmailAddress = emailAddress;
    }
}
namespace ItEmperor.Party.Contact;

public class ContactMechanism
{
    public Guid Id { get; init; }

    public ContactMechanismType ContactMechanismType { get; private set; }
    
    
    public string? Name { get; private set; }

    protected ContactMechanism()
    {
    }

    public ContactMechanism(ContactMechanismType contactMechanismType, string? name)
    {
        Id = Guid.NewGuid();
        ContactMechanismType = contactMechanismType;
        Name = name;
    }
}
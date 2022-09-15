namespace ItEmperor.Party.Classifications;

public class PartyType
{
    public Guid Id { get; init; }

    public string Description { get; set; }

    protected PartyType()
    {
    }

    public PartyType(string description)
    {
        Id = Guid.NewGuid();
        Description = description;
    }
}
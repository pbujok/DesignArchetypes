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

    public int PartyType { get; }
    
}
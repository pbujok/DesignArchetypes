namespace ItEmperor.Party;

public abstract class Party
{
    public PartyId Id { get; }
    
    public string Name { get; }
    
    public int PartyType { get; }
}
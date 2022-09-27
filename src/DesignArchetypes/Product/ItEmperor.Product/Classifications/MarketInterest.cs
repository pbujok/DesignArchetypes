namespace ItEmperor.Product.Classifications;

public class MarketInterest
{
    public Guid Id { get; init; }

    public PartyType PartyType { get; private set; }

    protected MarketInterest()
    {
    }

    public MarketInterest(PartyType partyType)
    {
        Id = Guid.NewGuid();
        PartyType = partyType;
    }
}
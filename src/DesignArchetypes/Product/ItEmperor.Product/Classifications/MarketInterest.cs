using ItEmperor.Product.Classifications.Category;

namespace ItEmperor.Product.Classifications;

public class MarketInterest
{
    public Guid Id { get; init; }

    public PartyType PartyType { get; private set; }

    public ProductCategory ProductCategory { get; private set; }

    protected MarketInterest()
    {
    }

    public MarketInterest(PartyType partyType, ProductCategory productCategory)
    {
        Id = Guid.NewGuid();
        PartyType = partyType;
        ProductCategory = productCategory;
    }
}
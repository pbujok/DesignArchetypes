namespace ItEmperor.Product.Classifications.Category;

public class ProductCategory
{
    public Guid Id { get; init; }

    public string Description { get; private set; }

    public List<MarketInterest> MarketInterests = new List<MarketInterest>();

    public List<ProductCategoryRollup> ProductCategoryParentsRollup = new List<ProductCategoryRollup>();

    protected ProductCategory()
    {
    }

    public ProductCategory(string description)
    {
        Id = Guid.NewGuid();
        Description = description;
    }
    
    public void SetParent(ProductCategory category)
    {
        ProductCategoryParentsRollup.Add(new ProductCategoryRollup(category, this));
    }
    
    public void SetMarketInterest(PartyType partyType)
    {
        MarketInterests.Add(new MarketInterest(partyType, this));
    }
}
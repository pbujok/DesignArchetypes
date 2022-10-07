namespace ItEmperor.Product.Feature;

public class ProductFeature
{
    public Guid Id { get; init; }

    public string Description { get; }

    public ProductFeatureCategory Category { get; }

    public ProductFeature(string description, ProductFeatureCategory category)
    {
        Description = description;
        Category = category;
    }
}
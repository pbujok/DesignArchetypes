namespace ItEmperor.Product.Classifications;

public class ProductCategory
{
    public Guid Id { get; init; }

    public string Description { get; private set; }

    protected ProductCategory()
    {
    }

    public ProductCategory(string description)
    {
        Id = Guid.NewGuid();
        Description = description;
    }
}
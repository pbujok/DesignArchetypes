namespace ItEmperor.Product.Classifications;

public class ProductCategoryRollup
{
    public Guid Id { get; set; }

    public ProductCategory Parent { get; private set; }

    public ProductCategory Child { get; private set; }

    protected ProductCategoryRollup()
    {
    }

    public ProductCategoryRollup(ProductCategory parent, ProductCategory child)
    {
        Id = Guid.NewGuid();
        Parent = parent;
        Child = child;
    }
}
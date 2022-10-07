namespace ItEmperor.Product.Feature.Interactions;

public abstract class ProductFeatureInteraction
{
    public Guid Id { get; init; }

    public ProductFeature? SelectedIn { get; set; }

    public ProductFeature? DependentOnSelectedIn { get; set; }

    public Product? ContextProduct { get; set; }

    protected ProductFeatureInteraction(ProductFeature? selectedIn, ProductFeature? dependentOnSelectedIn,
        Product? contextProduct)
    {
        Id = Guid.NewGuid();
        SelectedIn = selectedIn;
        DependentOnSelectedIn = dependentOnSelectedIn;
        ContextProduct = contextProduct;
    }
}
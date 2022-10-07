namespace ItEmperor.Product.Feature.Interactions;

public class FeatureInteractionDependency : ProductFeatureInteraction
{
    public FeatureInteractionDependency(ProductFeature? selectedIn, ProductFeature? dependentOnSelectedIn,
        Product? contextProduct) : base(selectedIn, dependentOnSelectedIn, contextProduct)
    {
    }
}
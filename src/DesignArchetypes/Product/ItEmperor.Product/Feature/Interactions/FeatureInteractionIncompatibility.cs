namespace ItEmperor.Product.Feature.Interactions;

public class FeatureInteractionIncompatibility : ProductFeatureInteraction
{
    public FeatureInteractionIncompatibility(ProductFeature? selectedIn, ProductFeature? dependentOnSelectedIn,
        Product? contextProduct) : base(selectedIn, dependentOnSelectedIn, contextProduct)
    {
    }
}
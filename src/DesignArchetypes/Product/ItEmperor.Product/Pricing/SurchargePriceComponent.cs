using ItEmperor.Product.Classifications;
using ItEmperor.Product.Feature;

namespace ItEmperor.Product.Pricing;

public class SurchargePriceComponent : PriceComponent
{
    public PartyType? PartyType { get; set; }
    
    public GeoBoundary? GeoBoundary { get; set; }
    
    public SurchargePriceComponent(ProductFeature? productFeature, Product? product, DateTime fromDate) : base(
        productFeature, product, fromDate)
    {
    }
}
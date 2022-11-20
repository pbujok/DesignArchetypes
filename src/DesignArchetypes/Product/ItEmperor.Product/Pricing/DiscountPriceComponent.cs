using ItEmperor.Product.Feature;

namespace ItEmperor.Product.Pricing;

public class DiscountPriceComponent : PriceComponent
{
    public GeoBoundary? GeoBoundary { get; set; }
    public DiscountPriceComponent(ProductFeature? productFeature, Product? product, DateTime fromDate) : base(
        productFeature, product, fromDate)
    {
    }
}
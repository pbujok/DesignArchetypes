using ItEmperor.Product.Feature;

namespace ItEmperor.Product.Pricing;

public class BasePrice : PriceComponent
{
    public BasePrice(ProductFeature? productFeature, Product? product, DateTime fromDate, int price) : base(
        productFeature, product, fromDate)
    {
        Price = price;
    }
}
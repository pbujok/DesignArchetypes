using ItEmperor.Product.Feature;

namespace ItEmperor.Product.Pricing;

public abstract class PriceComponent
{
    public ProductFeature? ProductFeature { get; set; }

    public Product? Product { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime? EndDate { get; set; }

    //Can be replaced with Money VO
    public int? Price { get; protected set; }

    public int? Percent { get; protected set; }

    public string Commment { get; set; }

    protected PriceComponent(ProductFeature? productFeature, Product? product, DateTime fromDate)
    {
        ProductFeature = productFeature;
        Product = product;
        FromDate = fromDate;
    }

    public void SetPriceValue(int? price)
    {
        Price = price;
        Percent = null;
    }

    public void SetPercentValue(int? percent)
    {
        Percent = percent;
        Price = null;
    }
}
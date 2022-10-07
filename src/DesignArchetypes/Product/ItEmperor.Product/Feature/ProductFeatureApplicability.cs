namespace ItEmperor.Product.Feature;

public class ProductFeatureApplicability
{
    public Guid Id { get; init; }

    public DateTime DateFrom { get; }

    public DateTime? DateTo { get; }

    public ApplicabilityType Type { get; set; }

    public ProductFeature ProductFeature { get; }

    public Product Product { get; }

    public ProductFeatureApplicability(DateTime dateFrom, DateTime? dateTo, ApplicabilityType type,
        ProductFeature productFeature, Product product)
    {
        Id = Guid.NewGuid();
        DateFrom = dateFrom;
        DateTo = dateTo;
        Type = type;
        ProductFeature = productFeature;
        Product = product;
    }
}
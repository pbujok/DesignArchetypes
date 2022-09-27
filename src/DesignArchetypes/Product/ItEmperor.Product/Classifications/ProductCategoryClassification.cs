namespace ItEmperor.Product.Classifications;

public class ProductCategoryClassification
{
    public Guid Id { get; init; }

    public string? Comment { get; private set; }

    public DateTime FromDate { get; private set; }

    public DateTime? EdnDate { get; private set; }

    public Product Product { get; private set; }

    public ProductCategory ProductCategory { get; private set; }

    public ProductCategoryClassification()
    {
    }

    public ProductCategoryClassification(string? comment, DateTime fromDate, DateTime? ednDate, Product product,
        ProductCategory productCategory)
    {
        Id = Guid.NewGuid();
        Comment = comment;
        FromDate = fromDate;
        EdnDate = ednDate;
        Product = product;
        ProductCategory = productCategory;
    }
}
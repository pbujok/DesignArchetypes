using ItEmperor.Product.Classifications;

namespace ItEmperor.Product;

public class Good : Product
{
    protected Good()
    {
    }

    public Good(string name, DateTime introductionDate, DateTime? supportEndDate, string? comment)
        : base(name, introductionDate, supportEndDate, comment)
    {
    }

    public void AssignCategory(GoodsCategory category, DateTime fromDate, DateTime? endDate)
    {
        this.ProductCategoryClassification.Add(new ProductCategoryClassification(
            null, fromDate, endDate, this, category));
    }
}
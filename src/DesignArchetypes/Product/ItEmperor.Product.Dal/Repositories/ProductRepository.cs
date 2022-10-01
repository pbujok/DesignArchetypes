namespace ItEmperor.Product.Dal.Repositories;

public class ProductRepository
{
    public void Add(Product product)
    {
        using var context = new ProductDbContext();
        context.AttachRange(product.ProductCategoryClassification.Select(x => x.ProductCategory));
        context.Set<Product>().Add(product);
        context.SaveChanges();
    }
}
namespace ItEmperor.Product.Dal.Repositories;

public class ProductRepository
{
    public void Add(Product product)
    {
        using var context = new ProductDbContext();
        context.Set<Product>().Add(product);
        context.SaveChanges();
    }
}
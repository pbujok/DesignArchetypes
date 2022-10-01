using ItEmperor.Product.Classifications;
using ItEmperor.Product.Dal;
using ItEmperor.Product.Dal.Repositories;
using Xunit;

namespace ItEmperor.Product.Tests;

public class ProductClassificationTests
{
    [Fact]
    public void SaveProductCategory_ValidObject_Saved()
    {
        AddIfNotExists(ProductTestData.Categories.Goods.Books);

        var product = ProductTestData.Products.Goods.LenSilverstonBook;
        product.AssignCategory(ProductTestData.Categories.Goods.Books, ProductTestData.Date1, null);
    }

    private static void AddIfNotExists(ProductCategory type)
    {
        using var context = new ProductDbContext();
        if (!context.Set<ProductCategory>().Any(x => x.Id == type.Id))
        {
            context.Set<ProductCategory>().Add(type);
        }

        context.SaveChanges();
    }
}
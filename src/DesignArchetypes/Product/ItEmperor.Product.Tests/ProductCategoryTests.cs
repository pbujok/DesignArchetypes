using ItEmperor.Product.Classifications;
using ItEmperor.Product.Classifications.Category;
using ItEmperor.Product.Dal;
using Xunit;

namespace ItEmperor.Product.Tests;

public class ProductCategoryTests
{
    [Fact]
    public void CreateProductCategory_AllDependenciesDefined_Created()
    {
        AddIfNotExists(ProductTestData.Categories.Goods.Books);

        var baseCategory = ProductTestData.Categories.Goods.Books;
        
        var category = new ServicesCategory("Programming");
        category.SetParent(baseCategory);
        AddIfNotExists(category);
        
        var category2 = new ServicesCategory(".NET Programming");
        category2.SetParent(category);
        AddIfNotExists(category2);
        
        var category3 = new ServicesCategory("Angular programming");
        category3.SetParent(category);
        AddIfNotExists(category3);
    }

    [Fact]
    public void AssignMarketInterest_ValidSetup_Assigned()
    {
        var category = new ServicesCategory("Programming");
        category.SetMarketInterest(PartyType.Company);
        
        AddIfNotExists(category);
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
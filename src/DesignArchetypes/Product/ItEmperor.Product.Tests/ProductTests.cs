using ItEmperor.Product.Dal.Repositories;
using Xunit;

namespace ItEmperor.Product.Tests;

public class ProductTests
{
    private readonly ProductRepository _repo = new ProductRepository();

    [Fact]
    public void SaveGoods_ValidObject_Saved()
    {
        var person = ProductTestData.Products.Services.QualityAssurance;
        var good = ProductTestData.Products.Goods.FowlerBook;

        _repo.Add(person);
        _repo.Add(good);
    }
}
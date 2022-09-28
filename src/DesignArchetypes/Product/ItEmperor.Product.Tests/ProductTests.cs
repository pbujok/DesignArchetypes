using ItEmperor.Product.Dal.Repositories;
using Xunit;

namespace ItEmperor.Product.Tests;

public class ProductTests
{
    private readonly ProductRepository _repo = new ProductRepository();
    
    [Fact]
    public void SaveGoods_ValidObject_Saved()
    {
        var person = ProductTestData.Services.QualityAssurance;

        _repo.Add(person);
    }
}
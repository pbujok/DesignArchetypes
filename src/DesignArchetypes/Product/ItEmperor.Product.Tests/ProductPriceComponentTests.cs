using ItEmperor.Product.Pricing;
using Xunit;

namespace ItEmperor.Product.Tests;

public class ProductPriceComponentTests
{
    [Fact]
    public void CreatePriceComponents_MultipleComponentsStructure_Created()
    {
        var product = new Service("It Sercices", ProductTestData.Date1, null, "");
        var swiss = new GeoBoundary(Guid.NewGuid(), "Swiss", "CH");
        var rus = new GeoBoundary(Guid.NewGuid(), "Russia", "RUS");

        var priceComponents = new List<PriceComponent>();

        var basePrice = new BasePrice(null, product, ProductTestData.Date1, 2137);
        priceComponents.Add(basePrice);

        var discount = new DiscountPriceComponent(null, product, ProductTestData.Date1)
        {
            GeoBoundary = swiss
        };
        discount.SetPriceValue(137);
        priceComponents.Add(discount);

        var surcharge = new SurchargePriceComponent(null, product, ProductTestData.Date1)
        {
            GeoBoundary = rus
        };
        surcharge.SetPercentValue(1000);
        priceComponents.Add(surcharge);

        var service = new PriceCalculator();
        Assert.Equal(23507, service.CalculatePrice(priceComponents, rus));
        Assert.Equal(2000, service.CalculatePrice(priceComponents, swiss));
    }
}
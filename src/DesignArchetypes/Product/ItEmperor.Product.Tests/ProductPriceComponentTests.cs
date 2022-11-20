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

        Assert.Equal(23507, CalculatePrice(priceComponents, rus));
        Assert.Equal(2000, CalculatePrice(priceComponents, swiss));
    }

    private int CalculatePrice(ICollection<PriceComponent> priceComponents, GeoBoundary geoBoundary)
    {
        var baseComponent = priceComponents.Single(x => x is BasePrice);

        var price = baseComponent.Price!.Value;
        var discounts = priceComponents.OfType<DiscountPriceComponent>()
            .Where(x => x.GeoBoundary == geoBoundary).ToList();
        foreach (var discount in discounts)
        {
            var discountValue = discount.Price.HasValue ? discount.Price.Value : (discount.Percent / 100) * price;
            price -= discountValue!.Value;
        }

        var surcharges = priceComponents.OfType<SurchargePriceComponent>()
            .Where(x => x.GeoBoundary == geoBoundary).ToList();
        foreach (var surcharge in surcharges)
        {
            var surchargeValue = surcharge.Price.HasValue ? surcharge.Price.Value : (surcharge.Percent / 100) * price;
            price += surchargeValue!.Value;
        }

        return price;
    }
}
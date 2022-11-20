namespace ItEmperor.Product.Pricing;

public class PriceCalculator
{
    public int CalculatePrice(ICollection<PriceComponent> priceComponents, GeoBoundary geoBoundary)
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
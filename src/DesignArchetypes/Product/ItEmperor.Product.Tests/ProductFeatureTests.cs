using ItEmperor.Product.Feature;
using ItEmperor.Product.Feature.Interactions;
using Xunit;

namespace ItEmperor.Product.Tests;

public class ProductFeatureTests
{
    [Fact]
    public async void ProductFeature_DefinedFeatures_ValidApplicability()
    {
        var blueColorFeature = new ProductFeature("Blue", ProductFeatureCategory.Color);
        var redColorFeature = new ProductFeature("Red", ProductFeatureCategory.Color);

        var product = new Product("Orient Ray II", ProductTestData.Date1, null, "Orient Ray II Watch");

        var interaction = new FeatureInteractionIncompatibility(blueColorFeature, redColorFeature, product);

        var redColorApplicability = new ProductFeatureApplicability(ProductTestData.Date1, null,
            ApplicabilityType.Selectable, redColorFeature, product);

        var blueColorApplicability = new ProductFeatureApplicability(ProductTestData.Date1, null,
            ApplicabilityType.Selectable, blueColorFeature, product);
    }

    [Fact]
    public async void DefineProductFeature_NewFeature_ValidApplicability()
    {
        var blueColorFeature = new ProductFeature("Blue", ProductFeatureCategory.Color);
        var redColorFeature = new ProductFeature("Red", ProductFeatureCategory.Color);

        var interaction = new FeatureInteractionIncompatibility(blueColorFeature, redColorFeature, null);
    }
    
    [Fact]
    public async void DefineProductFeature_DependentFeatures_ValidApplicability()
    {
        var mechanicFeature = new ProductFeature("Automatic", ProductFeatureCategory.Mechanism);
        var redColorFeature = new ProductFeature("Red", ProductFeatureCategory.Color);
        
        var quartzFeature = new ProductFeature("Quartz", ProductFeatureCategory.Mechanism);
        var whiteColorFeature = new ProductFeature("White", ProductFeatureCategory.Color);

        
        var dependency = new FeatureInteractionDependency(whiteColorFeature, quartzFeature, null);
        var interactionIncompatibility = new FeatureInteractionIncompatibility(quartzFeature, mechanicFeature, null);
    }
}
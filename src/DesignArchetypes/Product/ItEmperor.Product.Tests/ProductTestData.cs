using ItEmperor.Product.Classifications;
using ItEmperor.Product.Classifications.Category;

namespace ItEmperor.Product.Tests;

public class ProductTestData
{
    public static readonly DateTime Date1 = new(2000, 9, 11);

    public static readonly DateTime Date2 = new(2019, 11, 11);

    public static readonly DateTime Date3 = new(2022, 9, 15);

    public static class Products
    {
        public static class Services
        {
            public static readonly Service SoftwareDevelopment = new("Development", Date1, null, "Software Development");

            public static readonly Service QualityAssurance = new("QA", Date1, null, "Testing");
        }

        public static class Goods
        {
            public static readonly Good LenSilverstonBook = new("Data Model Resource Book", Date1, null,
                "Len Silverston - Data Model Resource Book");

            public static readonly Good DavidHayBook =
                new("Data Model Patter", Date1, null, "David C. Hay - Data Model Patter");

            public static readonly Good FowlerBook =
                new("Analysis Patterns", Date1, null, "M. Fowler - Analysis Patterns");
        }
    }

    public static class Categories
    {
        public static class Goods
        {
            public static readonly GoodsCategory Books = new("Books")
            {
                Id = new Guid("08ddd855-91db-4eae-9112-f8df37e52e43")
            };
        }
        
        public static class Services
        {
            public static readonly ServicesCategory ItServices = new("It Services")
            {
                Id = new Guid("7f5e322d-7688-4c49-9b70-f9c239bcb4d8")
            };
        }
    }
}
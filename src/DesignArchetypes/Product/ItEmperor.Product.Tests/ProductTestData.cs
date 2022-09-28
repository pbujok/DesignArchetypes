namespace ItEmperor.Product.Tests;

public class ProductTestData
{
    public static readonly DateTime Date1 = new DateTime(2000, 9, 11);

    public static readonly DateTime Date2 = new DateTime(2019, 11, 11);
    
    public static readonly DateTime Date3 = new DateTime(2022, 9, 15);

    public static class Services
    {
        public static readonly Service SoftwareDevelopment = new Service("Development", Date1, null, "Software Development");

        public static readonly Service QualityAssurance = new Service("QA", Date1, null, "Testing");
    }
    
    public static class Goods
    {
        public static readonly Good CourseAccess = new Good("Course access", Date1, Date3, "Design Archetypes course acccess");

        public static readonly Good OfficeSupply = new Good("Office supply", Date1, null, "Office supplies");
    }
}
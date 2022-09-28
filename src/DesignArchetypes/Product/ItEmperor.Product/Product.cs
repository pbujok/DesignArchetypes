namespace ItEmperor.Product;

public class Product
{
    public Guid Id { get; init; }

    public string Name { get; private set; }

    public DateTime IntroductionDate { get; private set; }

    public DateTime? SupportEndDate { get; private set; }

    public string? Comment { get; private set; }

    protected Product()
    {
    }

    public Product(string name, DateTime introductionDate, DateTime? supportEndDate, string? comment)
    {
        Id = Guid.NewGuid();
        Name = name;
        IntroductionDate = introductionDate;
        SupportEndDate = supportEndDate;
        Comment = comment;
    }
}
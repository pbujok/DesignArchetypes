namespace ItEmperor.Product;

public class Service : Product
{
    protected Service()
    {
    }

    public Service(string name, DateTime introductionDate, DateTime supportEndDate, string? comment) : base(name,
        introductionDate, supportEndDate, comment)
    {
    }
}
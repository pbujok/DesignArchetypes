namespace ItEmperor.Product;

public class Good : Product
{
    protected Good()
    {
    }

    public Good(string name, DateTime introductionDate, DateTime? supportEndDate, string? comment) 
        : base(name, introductionDate, supportEndDate, comment)
    {
    }
}
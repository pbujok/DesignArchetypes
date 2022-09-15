namespace ItEmperor.Party.Classifications.Organizations;

public class IncomePartyType : PartyType
{
    private const string DefaultCurrency = "PLN";

    public static IncomePartyType MicroCompany =
        new(null, new Income(2, DefaultCurrency), "< 2 000 000 PLN")
        {
            Id = new Guid("51858341-7b33-45d7-881b-65275a9c686d")
        };

    public static IncomePartyType SmallCompany =
        new(new Income(2, DefaultCurrency), new Income(10, DefaultCurrency),
            "2 000 000 - 10 000 000 PLN")
        {
            Id = new Guid("fd426952-4cee-4325-be39-a00439155a7d")
        };

    public static IncomePartyType MediumCompany =
        new(new Income(10, DefaultCurrency), new Income(50, DefaultCurrency), "10 000 000 - 50 000 000")
        {
            Id = new Guid("4913e98c-f1e6-42fe-829b-3b2262b3b955")
        };

    public static IncomePartyType LargeCompany =
        new(new Income(5000000, DefaultCurrency), null, "> 50 000 000 PLN")
        {
            Id = new Guid("14ef2bab-f468-4381-bcd8-7e10abeb01de")
        };

    public Income? IncomeFrom { get; private set; }

    public Income? IncomeTo { get; private set; }

    private IncomePartyType()
    {
    }

    protected IncomePartyType(Income? incomeFrom, Income? incomeTo, string description) : base(description)
    {
        IncomeFrom = incomeFrom;
        IncomeTo = incomeTo;
    }
}
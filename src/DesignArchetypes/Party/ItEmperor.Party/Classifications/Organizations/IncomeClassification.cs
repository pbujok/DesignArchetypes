using ItEmperor.Party.Organizations;

namespace ItEmperor.Party.Classifications.Organizations;

public class IncomeClassification : PartyClassification
{
    protected IncomeClassification()
    {
    }

    public IncomeClassification(DateTimeOffset fromDate, DateTimeOffset? endDate, Organization party, IncomePartyType type) 
        : base(fromDate, endDate, party, type)
    {
    }
}
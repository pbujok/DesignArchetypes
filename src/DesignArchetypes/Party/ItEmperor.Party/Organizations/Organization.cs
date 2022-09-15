using ItEmperor.Party.Addresses.Complex;
using ItEmperor.Party.Classifications.Organizations;

namespace ItEmperor.Party.Organizations;

public class Organization : Party
{
    protected Organization() : base()
    {
    }

    public Organization(TaxId taxId, string name) : base(PartyId.New(), name)
    {
        TaxId = taxId;
    }

    public TaxId TaxId { get; set; }

    public ICollection<Position> Positions { get; set; } = new List<Position>();

    public List<Placement> Placements { get; set; } = new List<Placement>();


    public void AddPosition(string description, int hourSalaryFrom, int hourSalaryTo)
    {
        Positions.Add(new Position(description, hourSalaryFrom, hourSalaryTo, this));
    }

    public void AddPlacement(DateTimeOffset effectiveDate, DateTimeOffset? endDate, Site site)
    {
        Placements.Add(new Placement(effectiveDate, endDate, site));
    }

    public void AddIncomeClassification(DateTimeOffset dateFrom, DateTimeOffset? dateTo, IncomePartyType partyType)
    {
        PartyClassifications.Add(new IncomeClassification(dateFrom, dateTo, this, partyType));
    }
}
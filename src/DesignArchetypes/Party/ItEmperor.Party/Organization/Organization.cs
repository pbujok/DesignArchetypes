using System;
using System.Collections.Generic;
using ItEmperor.Party.Address.Complex;

namespace ItEmperor.Party.Organization;

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
}
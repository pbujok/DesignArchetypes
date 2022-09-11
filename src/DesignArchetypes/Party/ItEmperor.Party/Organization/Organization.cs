using System.Runtime.InteropServices;

namespace ItEmperor.Party;

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
    
    public ICollection<Position> Positions { get; set; }
}
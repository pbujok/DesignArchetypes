using ItEmperor.Party.Roles.RoleTypes;

namespace ItEmperor.Party.Relationships;

public class PartyRelationshipType
{
    public static PartyRelationshipType Employment { get; } =
        new("Person employmment", "Employment", PartyRoleType.Employee, PartyRoleType.Employer);
    
    public static PartyRelationshipType Customer { get; } =
        new("Company's customer", "Customer", PartyRoleType.Customer, PartyRoleType.Warehouse);
    
    public static PartyRelationshipType RetailSales { get; } =
        new("Retail sales", "RetailSales", PartyRoleType.Customer, PartyRoleType.RetailSales);
    
    public Guid Id { get; init; }

    public string Description { get; set; }

    public string Name { get; private set; }

    public PartyRoleType From { get; private set; }

    public PartyRoleType To { get; private set; }

    protected PartyRelationshipType()
    {
    }

    public PartyRelationshipType(string description, string name, PartyRoleType from, PartyRoleType to)
    {
        Id = Guid.NewGuid();
        Description = description;
        Name = name;
        From = from;
        To = to;
    }
}
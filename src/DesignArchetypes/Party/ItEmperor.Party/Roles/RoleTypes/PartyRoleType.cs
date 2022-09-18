namespace ItEmperor.Party.Roles.RoleTypes;

public class PartyRoleType : RoleType
{
    public static PartyRoleType Employee { get; } = new("Employee")
    {
        Id = new Guid("0e6a2c80-7147-4047-b04c-875317ff023d")
    };
    
    public static PartyRoleType Employer { get; } = new("Employer")
    {
        Id = new Guid("396b2c5e-bbfd-4eb2-b160-a622992e7b09")
    };

    public static PartyRoleType Customer { get; } = new("Customer")
    {
        Id = new Guid("46694c99-33f7-405f-b9db-737bec0e6f46")
    };
    
    public static PartyRoleType Provider { get; } = new("Customer")
    {
        Id = new Guid("701a5fc8-c0d0-4acd-839e-4698a86611d0")
    };
    
    protected PartyRoleType()
    {
    }

    public PartyRoleType(string description) : base(description)
    {
    }
}
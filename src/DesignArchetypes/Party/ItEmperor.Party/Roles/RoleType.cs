namespace ItEmperor.Party.Roles.RoleTypes;

public abstract class RoleType
{
    public Guid Id { get; init; }

    public string Description { get; private set; }

    protected RoleType()
    {
    }

    protected RoleType(string description)
    {
        Id = Guid.NewGuid();
        Description = description;
    }
}
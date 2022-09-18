using ItEmperor.Party.Roles;
using ItEmperor.Party.Roles.PartyRoles;
using ItEmperor.Party.Roles.RoleTypes;

namespace ItEmperor.Party.Relationships;

public class PartyRelationship
{
    public Guid Id { get; private set; }

    public PartyRole From { get; private set; }

    public PartyRole To { get; private set; }

    public DateTimeOffset StartDate { get; private set; }

    public DateTimeOffset? EndDate { get; private set; }

    public PartyRelationshipType? PartyRelationshipType { get; private set; }

    public string? Comment { get; private set; }

    protected PartyRelationship()
    {
    }

    public PartyRelationship(PartyRole from, PartyRole to, DateTimeOffset startDate, DateTimeOffset? endDate)
        : this(from, to, startDate, endDate, null!, null)
    {
    }

    public PartyRelationship(PartyRole from, PartyRole to, DateTimeOffset startDate, DateTimeOffset? endDate,
        string comment, PartyRelationshipType? partyRelationshipType)
    {
        Id = Guid.NewGuid();
        From = from;
        To = to;
        StartDate = startDate;
        EndDate = endDate;
        Comment = comment;
        PartyRelationshipType = partyRelationshipType;
    }
}
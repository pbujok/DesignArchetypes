using ItEmperor.Party.Relationships;

namespace ItEmperor.Party.Tests.Repositories;

public class PartyRelationshipRepository
{
    public void Add(PartyRelationship partyRelationship)
    {
        using var partyContext = new PartyDbContext();
        partyContext.Attach(partyRelationship.To.Party);
        partyContext.Attach(partyRelationship.From.Party);
        partyContext.Attach(partyRelationship.PartyRelationshipType);
        partyContext.Attach(partyRelationship.From.RoleType);
        partyContext.Attach(partyRelationship.To.RoleType);
        partyContext.Set<PartyRelationship>().Add(partyRelationship);
        partyContext.SaveChanges();
    }
}
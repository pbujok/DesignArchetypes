namespace ItEmperor.Party.Tests.Repositories;

public class PartyRepository : IPartyRepository
{
    public void Add(Party party)
    {
        using var partyContext = new PartyDbContext();
        partyContext.AttachRange(party.PartyRoles.Select(x => x.RoleType));
        partyContext.AttachRange(party.PartyClassifications.Select(x => x.Type));
        partyContext.Set<Party>().Add(party);
        partyContext.SaveChanges();
    }
}
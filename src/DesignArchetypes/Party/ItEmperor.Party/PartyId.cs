namespace ItEmperor.Party;

public record PartyId(Guid Value)
{
    public static PartyId New() => new PartyId(Guid.NewGuid());
}
namespace ItEmperor.Party.Addresses.Complex;

public class Placement
{
    protected Placement()
    {
    }

    public Placement(DateTimeOffset effectiveDate, DateTimeOffset? endDate, Site site)
    {
        Id = Guid.NewGuid();
        EffectiveDate = effectiveDate;
        EndDate = endDate;
        Site = site;
    }

    public Guid Id { get; }

    public DateTimeOffset EffectiveDate { get; private set; }

    public DateTimeOffset? EndDate { get; private set; }

    public Site Site { get; private set; }
}
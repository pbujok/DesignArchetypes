namespace ItEmperor.Party.Employment.Complex;

public class Position
{
    protected Position()
    {
    }

    public Position(string description, int haurSalaryFrom, int hourSalaryTo)
    {
        Id = Guid.NewGuid();
        Description = description;
        HaurSalaryFrom = haurSalaryFrom;
        HourSalaryTo = hourSalaryTo;
    }

    public Guid Id { get; }

    public string Description { get; private set; }

    public int HaurSalaryFrom { get; private set; }

    public int HourSalaryTo { get; private set; }

    public Organization.Organization Organization { get; private set; }
}
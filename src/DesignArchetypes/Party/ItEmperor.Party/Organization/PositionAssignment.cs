namespace ItEmperor.Party;

public class PositionAssignment
{
    public Guid Id { get; set; }
    
    public DateTime StartData { get; set; }

    public DateTime EndDate { get; set; }

    public Position Position { get; set; }
}
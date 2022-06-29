namespace ItEmperor.Party;

public class Employment
{
    public Person Person { get; set; }
    
    public Organization Organization { get; set; }
    
    public PositionAssignment BasedOnPossitonAssignment { get; set; }
}
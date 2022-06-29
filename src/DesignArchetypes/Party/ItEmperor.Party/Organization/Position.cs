namespace ItEmperor.Party;

public class Position
{
    public string Description { get; set; }
    
    public int PaymentFrom { get; set; }
    
    public int PaymentTo { get; set; }
    
    public Organization Organization { get; set; }
}
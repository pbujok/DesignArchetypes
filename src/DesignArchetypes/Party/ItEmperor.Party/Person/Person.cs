namespace ItEmperor.Party;

public class Person : Party
{
    protected Person() : base()
    {
    }
    
    public Person(string firstName, string lastName) : base(PartyId.New(), $"{firstName} {lastName}")
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public ICollection<Employment> Employments { get; set; }
}
namespace ItEmperor.Party;

public class Address
{
    public Guid Id { get; }

    public string Text { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string PostalCode { get; set; }

    public string Type { get; set; }
}

public class Placement
{
    public string Text { get; set; }
}

public class Site
{
    public string Purpose { get; set; }

    public string Type { get; set; }

    public string AddressText { get; set; }
}
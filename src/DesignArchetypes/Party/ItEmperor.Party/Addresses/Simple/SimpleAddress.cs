namespace ItEmperor.Party.Addresses.Simple;

public class SimpleAddress
{
    public Guid Id { get; init; }

    public string Text { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string PostalCode { get; set; }

    public string Type { get; set; }
}
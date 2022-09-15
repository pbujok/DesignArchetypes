namespace ItEmperor.Party.Addresses.Complex;

public class Site
{
    protected Site()
    {
        
    }
    
    public Site(string purpose, string addressText, GeographicLocation geographicLocation)
    {
        Purpose = purpose;
        AddressText = addressText;
        GeographicLocation = geographicLocation;
    }

    public string Purpose { get; private set; }

    public string AddressText { get; private set; }

    public GeographicLocation GeographicLocation { get; private set; }
}
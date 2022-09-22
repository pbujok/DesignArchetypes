namespace ItEmperor.Party.Addresses.Complex;

public class Site
{
    public string Purpose { get; private set; }

    public string AddressText { get; private set; }

    public GeographicLocation GeographicLocation { get; private set; }
    
    protected Site()
    {
        
    }
    
    public Site(string purpose, string addressText, GeographicLocation geographicLocation)
    {
        Purpose = purpose;
        AddressText = addressText;
        GeographicLocation = geographicLocation;
    }
}
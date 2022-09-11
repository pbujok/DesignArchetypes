namespace ItEmperor.Shared;

public class ConnectionStringProvider : IConnectionStringProvider
{
    public string Get()
    {
        return "Server=.;Database=DesignArchetypes;Integrated Security=SSPI;";
    }
}
using System;

namespace ItEmperor.Party.Address.Complex;

public class GeographicLocation
{
    protected GeographicLocation()
    {
        
    }

    public GeographicLocation(string value, GeographicLocationType type)
    {
        Id = Guid.NewGuid();
        Value = value;
        Type = type;
    }

    public GeographicLocation(string value, GeographicLocationType type, GeographicLocation childOf)
    {
        Id = new Guid();
        Value = value;
        Type = type;
        ChildOf = childOf;
    }

    public Guid Id { get; }

    public string Value { get; }

    public GeographicLocationType Type { get; }

    public GeographicLocation? ChildOf { get; }
}
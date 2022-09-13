using System;

namespace ItEmperor.Party.Employment.Simple;

public class SimpleEmployment
{
    public Guid Id { get; init; }

    public string Type { get; set; }

    public DateTimeOffset StartDate { get; set; }

    public DateTimeOffset EndDate { get; set; }


    public Person.Person Person { get; set; }

    public Organization.Organization Organization { get; set; }
}
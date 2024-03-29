﻿namespace ItEmperor.Party.Organizations;

public class Position
{
    public Guid Id { get; }

    public string Description { get; private set; }

    public int HourSalaryFrom { get; private set; }

    public int HourSalaryTo { get; private set; }

    public Organization Organization { get; private set; }

    protected Position()
    {
    }

    public Position(string description, int hourSalaryFrom, int hourSalaryTo, Organization organization)
    {
        Id = Guid.NewGuid();
        Description = description;
        HourSalaryFrom = hourSalaryFrom;
        HourSalaryTo = hourSalaryTo;
        Organization = organization;
    }
}
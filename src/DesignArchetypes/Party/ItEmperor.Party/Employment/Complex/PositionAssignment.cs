using System;

namespace ItEmperor.Party.Employment.Complex;

public class PositionAssignment
{
    protected PositionAssignment()
    {
    }

    public PositionAssignment(DateTimeOffset startData, DateTimeOffset endDate, Position position)
    {
        Id = Guid.NewGuid();
        StartData = startData;
        EndDate = endDate;
        Position = position;
    }

    public Guid Id { get; }

    public DateTimeOffset StartData { get; private set; }

    public DateTimeOffset EndDate { get; private set; }

    public Position Position { get; private set; }
}
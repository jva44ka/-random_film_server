namespace RandomFilmServer.Domain.Services.Interfaces
{
    using System;

    public interface IDateTimeService
    {
        DateTime UtcNow();
        DateTimeOffset OffsetUtcNow();
    }
}
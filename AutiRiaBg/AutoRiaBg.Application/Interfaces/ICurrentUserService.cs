using AutoRiaBg.Domain.Entities;

namespace AutoRiaBg.Application.Interfaces
{
    public interface ICurrentUserService
    {
        string UserId { get; }
        User User { get; }
    }
}

namespace AutiRiaBg.Services
{
    using AutoRiaBg.Application.Interfaces;
    using AutoRiaBg.Domain.Entities;
    using Microsoft.AspNetCore.Http;
    using System.Linq;
    using System.Security.Claims;

    public class CurrentUserService : ICurrentUserService
    {
        public CurrentUserService(IHttpContextAccessor httpContextAccessor, IApplicationDbContext context)
        {
            UserId = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
            User = context.Users.SingleOrDefault(u => u.Id == UserId);
        }

        public string UserId { get; }
        public User User { get; }
    }
}

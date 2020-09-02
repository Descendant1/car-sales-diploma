namespace AutoRiaBg.Infrastructure.Identity
{
    using AutoRiaBg.Application.Interfaces;
    using AutoRiaBg.Application.Models;
    using AutoRiaBg.Domain.Entities;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class IdentityService : IIdentityService
    {
        private readonly UserManager<User> _userManager;

        public IdentityService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<string> GetUserNameAsync(string userId)
        {
            var user = await _userManager.Users.FirstAsync(u => u.Id == userId);

            return user.FirstName;
        }
        public async Task<(ActionResult Result, string UserId)> CreateUserAsync(string userName, string password)
        {
            var user = new User
            {
                FirstName = userName,
                LastName = userName,
            };

            var result = await _userManager.CreateAsync(user, password);

            return (result.ToApplicationResult(), user.Id);
        }

        public async Task<ActionResult> DeleteUserAsync(string userId)
        {
            var user = _userManager.Users.SingleOrDefault(u => u.Id == userId);

            if (user != null)
                return await DeleteUserAsync(user);

            return ActionResult.Success();
        }

        public async Task<ActionResult> DeleteUserAsync(User user)
        {
            var result = await _userManager.DeleteAsync(user);

            return result.ToApplicationResult();
        }
    }
}

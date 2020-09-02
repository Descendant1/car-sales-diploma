using AutoRiaBg.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AutoRiaBg.Application.Interfaces
{
    public interface IIdentityService
    {
        Task<string> GetUserNameAsync(string userId);

        Task<(ActionResult Result, string UserId)> CreateUserAsync(string userName, string password);

        Task<ActionResult> DeleteUserAsync(string userId);
    }
}

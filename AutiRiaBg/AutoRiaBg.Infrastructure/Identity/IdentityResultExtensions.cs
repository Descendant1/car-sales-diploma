namespace AutoRiaBg.Infrastructure.Identity
{
    using AutoRiaBg.Application.Models;
    using Microsoft.AspNetCore.Identity;
    using System.Linq;

    public static class IdentityResultExtensions
    {
        public static ActionResult ToApplicationResult(this IdentityResult result)
        {
            return result.Succeeded
                ? ActionResult.Success()
                : ActionResult.Failure(result.Errors.Select(e => e.Description));
        }
    }
}

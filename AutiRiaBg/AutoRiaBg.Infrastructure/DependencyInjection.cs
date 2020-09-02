namespace AutoRiaBg.Infrastructure
{
    using AutoRiaBg.Application.Interfaces;
    using AutoRiaBg.Domain.Entities;
    using AutoRiaBg.Infrastructure.Identity;
    using AutoRiaBg.Infrastructure.Persistence;
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(
                        configuration.GetConnectionString("DefaultConnection"),
                        b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName))); ;



            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());

            services.AddDefaultIdentity<User>()
                .AddEntityFrameworkStores<ApplicationDbContext>();
            


            services.AddTransient<IIdentityService, IdentityService>();

            services.AddAuthentication();
            //    .AddIdentityServerJwt();

            //services.AddIdentityServer();
                    //.AddApiAuthorization<User, ApplicationDbContext>();
            return services;
        }
    }
}

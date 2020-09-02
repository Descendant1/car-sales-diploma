namespace AutoRiaBg.Infrastructure.Persistence
{
    using AutoRiaBg.Application.Interfaces;
    using AutoRiaBg.Domain;
    using AutoRiaBg.Domain.Entities;
    using IdentityServer4.EntityFramework.Options;
    using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.ChangeTracking;
    using Microsoft.Extensions.Options;
    using System;
    using System.Reflection;
    using System.Threading;
    using System.Threading.Tasks;

    public class ApplicationDbContext : ApiAuthorizationDbContext<User>, IApplicationDbContext
    {
        private readonly ICurrentUserService _currentUserService;

        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions,
            ICurrentUserService currentUserService) : base(options, operationalStoreOptions)
        {
            _currentUserService = currentUserService;
        }

        public DbSet<CarAd> CarAds { get ; set; }
        public DbSet<Car> Cars{ get ; set; }
        public DbSet<Brand> Brands { get ; set; }
        public DbSet<Model> Models { get ; set; }
        public DbSet<SubModel> SubModels{ get ; set; }
        public DbSet<MultimediaDevice> MultimediaDevices { get ; set; }
        public DbSet<AdditionalService> AdditionalServices { get ; set; }
        
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.IdUserCreatedBy = _currentUserService.UserId;
                        entry.Entity.DateCreated = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.IdUserLastModifiedBy = _currentUserService.UserId;
                        entry.Entity.DateModified = DateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}

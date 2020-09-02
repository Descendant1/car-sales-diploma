using AutoRiaBg.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace AutoRiaBg.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<CarAd> CarAds { get; set; }

        DbSet<MultimediaDevice> MultimediaDevices { get; set; }
        DbSet<AdditionalService> AdditionalServices { get; set; }

        DbSet<Car> Cars { get; set; }
        DbSet<Brand> Brands { get; set; }
        DbSet<Model> Models { get; set; }
        DbSet<SubModel> SubModels { get; set; }

        DbSet<User> Users { get; set; }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}

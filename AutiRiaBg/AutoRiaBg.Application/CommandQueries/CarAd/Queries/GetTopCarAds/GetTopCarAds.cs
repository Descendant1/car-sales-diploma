namespace AutoRiaBg.Application.CommandQueries.CarAd.Queries.GetTopCarAds
{
    using AutoRiaBg.Application.Interfaces;
    using AutoRiaBg.Application.ViewModels;
    
    using MediatR;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    public class GetTopCarAds  : IRequest<CarAdsListViewModel>
    {


        public class Handler : IRequestHandler<GetTopCarAds, CarAdsListViewModel>
        {
            private readonly IApplicationDbContext _context;
            public Handler( IApplicationDbContext applicationDbContext )
            {
                _context = applicationDbContext;
            }
            public async Task<CarAdsListViewModel> Handle(GetTopCarAds request, CancellationToken cancellationToken)
            {

                CarAdsListViewModel model = new CarAdsListViewModel();

                model.Data = await _context.CarAds.Include(i=>i.Photos).Take(5).OrderByDescending(o => o.DateCreated).ToListAsync();

                foreach (var item in model.Data)
                {
                    item.Photos.RemoveRange(1, item.Photos.Count - 1);
                }

                /// to do add column for main photo/

                return model;
            }
        }
    }
}

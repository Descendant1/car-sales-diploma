

namespace AutoRiaBg.Application.CommandQueries.CarAd.Commands.CreateCarAd
{
    using AutiRiaBg.Application.ViewModels;
    using AutoRiaBg.Application.Interfaces;
    using AutoRiaBg.Domain.Entities;
    using MediatR;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    public class CreateCarAdCommand : IRequest<int>
    {
        public CarAdViewModel CarAdViewModel { get; set; }
        public string WebRootPath { get; set; }

        public class Handler : IRequestHandler<CreateCarAdCommand, int>
        {
            private readonly IApplicationDbContext _context;
            private readonly ICurrentUserService _currentUserService;

            public Handler(IApplicationDbContext applicationDbContext, ICurrentUserService currentUserService)
            {
                _context = applicationDbContext;
                _currentUserService = currentUserService;
            }

            public async Task<int> Handle(CreateCarAdCommand request, CancellationToken cancellationToken)
            {

                Domain.Entities.CarAd carAd = (Domain.Entities.CarAd)request.CarAdViewModel;
                User user = _currentUserService.User;

                carAd.User = user;
                carAd.IdUser = user.Id;

                _context.CarAds.Add(carAd);

                await _context.SaveChangesAsync();


                string path = Path.Combine(request.WebRootPath, Constants.CarAdsImagesFolderName, carAd.Id.ToString());

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                foreach (var file in request.CarAdViewModel.PhotoFiles)
                {
                    if ( !(file.Length > 0) )
                        continue;

                    string filePath = Path.Combine(path, file.FileName);
                    using (var stream = File.Create(filePath))
                        await file.CopyToAsync(stream);

                    carAd.Photos.Add(new CarPhoto { Car = carAd, CarId = carAd.Id, PhotoRelativePath = Path.Combine(carAd.Id.ToString(), file.FileName) });
                }
                _context.CarAds.Update(carAd);

                await _context.SaveChangesAsync();

                return carAd.Id;
            }
        }
    }


}

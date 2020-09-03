namespace AutiRiaBg.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoRiaBg.Application.CommandQueries.CarAd.Queries.GetCarAdsListByParameters;
    using AutoRiaBg.Application.CommandQueries.CarAd.Queries.GetTopCarAds;
    using AutoRiaBg.Application.Interfaces;
    using AutoRiaBg.Application.ViewModels;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Extensions.Logging;
    public class IndexModel : PageModelBase
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IApplicationDbContext _context;

        [ViewData]
        public CarAdsListViewModel Data { get; set; }
        [ViewData]
        public BrandsListViewModel BrandsListViewModel { get; set; }


        public IndexModel(ILogger<IndexModel> logger, IApplicationDbContext context )
        {
            _logger = logger;
            _context = context;

        }


        public async Task OnGet()
        {
            Data = await Mediator.Send(new GetTopCarAds());
            BrandsListViewModel = new BrandsListViewModel();
            BrandsListViewModel.Data = _context.Brands.ToList();


            //var a = await Mediator.Send(new GetCarAdsShortViewByBrand { searchModel = new CarAdSearchModel(r => r.Name.Contains("Lex")) });

        }
    }
}

namespace AutiRiaBg.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoRiaBg.Application.CommandQueries.CarAd.Queries.GetTopCarAds;
    using AutoRiaBg.Application.ViewModels;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Extensions.Logging;
    public class IndexModel : PageModelBase
    {
        private readonly ILogger<IndexModel> _logger;
        
        [ViewData]
        public CarAdsListViewModel Data { get; set; }


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

        }


        public async Task OnGet()
        {
            Data = await Mediator.Send(new GetTopCarAds());
        }
    }
}

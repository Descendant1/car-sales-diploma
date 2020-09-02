namespace AutiRiaBg.Pages
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using AutiRiaBg.Application.ViewModels;
    using AutoRiaBg.Application.Interfaces;
    using AutoRiaBg.Domain.Entities;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Collections.Generic;
    using System.IO;
    using Microsoft.AspNetCore.Hosting;
    using AutoRiaBg.Application.CommandQueries.CarAd.Commands.CreateCarAd;
    using Microsoft.AspNetCore.Authorization;

    [Authorize]
    public class CarAdsMainPageModel : PageModelBase
    {
        private readonly IApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly ICurrentUserService _currentUserService;
        public CarAdsMainPageModel(IApplicationDbContext context, IWebHostEnvironment environment, ICurrentUserService currentUserService)
        {
            _context = context;
            _hostingEnvironment = environment;
            _currentUserService = currentUserService;
        }

        public IActionResult OnGet()
        {
            List<SelectListItem> multimediaDevices = new List<SelectListItem>();
            foreach (var item in _context.MultimediaDevices.ToList())
                multimediaDevices.Add(new SelectListItem(item.Name, item.Name));

            List<SelectListItem> additionalServices = new List<SelectListItem>();
            foreach (var item in _context.AdditionalServices.ToList())
                additionalServices.Add(new SelectListItem(item.Name, item.Name));


            this.ViewData.Add("MMD", multimediaDevices);
            this.ViewData.Add("ADS", additionalServices);

            return Page();
        }

        [BindProperty]
        public CarAdViewModel CarAd { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.

        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
                return Page();

            int id = await Mediator.Send(new CreateCarAdCommand { CarAdViewModel = CarAd, WebRootPath = _hostingEnvironment.WebRootPath });

            return RedirectToPage("./Index");
        }
    }
}

namespace AutiRiaBg.Application.ViewModels
{
    using AutoRiaBg.Domain.Entities;
    using Microsoft.AspNetCore.Http;
    using System;
    using System.Collections.Generic;

    public class CarAdViewModel : CarAd
    {
        public CarAdViewModel()
        {
            PhotoFiles = new List<IFormFile>();
        }

        public List<IFormFile> PhotoFiles { get; set; }

    }
}

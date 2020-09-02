namespace AutoRiaBg.Domain.Entities
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Collections.Generic;
    using System.Net;

    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<CarAd> CarAds { get; set; }
        
        public DateTime DateRegistrated { get; set; }
        public DateTime Seen { get; set; }


    }
}

namespace AutoRiaBg.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using AutoRiaBg.Domain.Enums;

    public class CarAd : AuditableEntity
    {
        public CarAd()
        {
            this.Photos = new List<CarPhoto>();
            this.MultimediaDevices = new List<MultimediaDevice>();
            this.AdditionalServices = new List<AdditionalService>();
        }


        public int PublicId { get; set; }
        public string Header { get; set; }
        public float Price { get; set; }
        public float EngineVolume { get; set; }
        public bool IsFromSalon { get; set; }
        public string Region { get; set; }
        public int YearManagactured { get; set; }
        public int EngineHorsePowers { get; set; }
        public float ZeroToHundredInSeconds { get; set; }
        public string VIN { get; set ; }
        public string LicencePlates { get; set; }
        public bool IsNewRegistration { get; set; }
        public string CoutnryFrom { get; set; }
        public int Mileage { get; set; }
        public float? CityConsumption { get; set; }
        public float? HighwayConsumption { get; set; }
        public float? MixedConsumption { get; set; }
        public string Description { get; set; }
        public long NumberOfViews { get; set; }
        public bool IsInOrder { get; set; }


        #region Relation's
        public string IdUser { get; set; }
        public User User { get; set; }

        public int IdCar { get; set; }
        public Car Car { get; set; }

        public List<MultimediaDevice> MultimediaDevices { get; set; }
        public List<AdditionalService> AdditionalServices { get; set; }
        public List<CarPhoto> Photos { get; set; }

        #endregion


        #region Enums
        public BodyType BodyType { get; set; }
        public TransmissionType TransmissionType { get; set; }
        public FuelType FuelType { get; set; }
        public DriveType DriveType { get; set; }

        #endregion
    }
}

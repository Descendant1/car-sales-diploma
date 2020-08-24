namespace AutiRiaBg.Entities
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Car : AuditableEntity
    {
        public int PublicId { get; set; }
        public string Header { get; set; }

        public float Price { get; set; }

        public User User { get; set; }

        public BodyType BodyType { get; set; }
        public TransmissionType TransmissionType { get; set; }
        public FuelType FuelType { get; set; }
        public DriveType DriveType { get; set; }
        public float EngineVolume { get; set; }

        public bool IsFromSalon { get; set; }

        public string Region { get; set; }

        public int YearManagactured { get; set; }

        public int EngineHorsePowers { get; set; }

        public float ZeroToHundredInSeconds { get; set; }

        public List<MultimediaDevice> MultimediaDevices { get; set; }
        public List<AdditionalService> AdditionalServices { get; set; }
         
        public string VIN { get => VIN ; set => VIN = value.ToUpper()  ; }

        public string LicencePlates { get; set; }



        //Do key
        public List<CarPhoto> Photos { get; set; }



        public string Description { get; set; }
        //public double Price { get; set; }
        public DateTime TimeAdded { get; set; }
        public DateTime? DeleteTime { get; set; }
        public long NumberOfViews { get; set; }
        public bool IsInOrder { get; set; }

    }
    public enum BodyType
    {
        SUV
         , Truck
         , Cabriolet
         , Crossover
         , CrossoverCoupe
         , Coupe
         , Liftback
         , Minibus
         , Microvan
         , Minivan
         , Pickup
         , Roadster
         , Sedan
         , StationWagon
         , Fastback
         , Van
         , Hatchback
         , Chassis
    }
    public enum TransmissionType
    {
        Auto
        , Manual
    }
    public enum FuelType
    {
        Petrol
        , PetrolGas
        , Hybrid
        , Diesel
        , Electro
    }
    public enum DriveType
    {
        RWD
        , AWD
        , FWD
    }
    public class MultimediaDevice : AuditableEntity
    {
        public string Name { get; set; }
    }
    public class AdditionalService
    {
        public string Name { get; set; }
    }

}

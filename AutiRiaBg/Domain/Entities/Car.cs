namespace AutoRiaBg.Domain.Entities
{
    using System;
    public class Car : AuditableEntity
    {
        public int IdBrand { get; set; }
        public Brand Brand { get; set; }

    }
}

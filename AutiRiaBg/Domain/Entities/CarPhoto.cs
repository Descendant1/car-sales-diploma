namespace AutoRiaBg.Domain.Entities
{
    public class CarPhoto : AuditableEntity
    {
        public string PhotoRelativePath { get; set; }
        public int CarId { get; set; }
        public CarAd Car { get; set; }

    }
}

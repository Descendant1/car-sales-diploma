namespace AutoRiaBg.Domain.Entities
{
    public class SubModel : AuditableEntity
    {
        public string Name { get; set; }

        public int IdModel { get; set; }
        public Model Model { get; set; }
    }
}

// BMW 7th series 730d 

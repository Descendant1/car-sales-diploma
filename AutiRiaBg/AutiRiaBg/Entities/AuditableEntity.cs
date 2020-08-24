namespace AutiRiaBg.Entities
{
    using System;

    public abstract class AuditableEntity
    {
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public int IdUser { get; set; }
    }
}

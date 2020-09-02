namespace AutoRiaBg.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public abstract class AuditableEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string IdUserCreatedBy { get; set; }
        public string IdUserLastModifiedBy { get; set; }
        public DateTime? DateCreated { get; set; } 
        public DateTime? DateModified { get; set; }
        public DateTime? DeleteTime { get; set; }

    }
}

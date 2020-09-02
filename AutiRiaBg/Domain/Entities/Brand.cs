namespace AutoRiaBg.Domain.Entities
{
    using System.Collections.Generic;
    
    public class Brand : AuditableEntity
    {
        public Brand()
        {
            this.Models = new List<Model>();
        }

        public string Name { get; set; }
        public string LogoLink { get; set; }

        public List<Model> Models { get; set; }

    }
}

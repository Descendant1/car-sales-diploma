namespace AutoRiaBg.Domain.Entities
{
    using System.Collections.Generic;
    public class Model : AuditableEntity
    {

        public Model()
        {
            this.SubModels = new List<SubModel>();
        }
            
        public string Name { get; set; }

        public int IdBrand { get; set; }
        public Brand Brand { get; set; }

        public List<SubModel> SubModels { get; set; }
    }
}

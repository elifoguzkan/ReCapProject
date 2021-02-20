using Core.Entities;

namespace Entities.Concrete
{
    public class Id:IEntity
    {
        public int CarId { get; set; }
        public int ModelId { get; set; }
        public string BrandName { get; set; }
    }
}

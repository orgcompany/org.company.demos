
using System.ComponentModel.DataAnnotations;

namespace org.company.order.domain
{
    public partial class ProductType
    {
        [Key]
        public int ProductTypeId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

    }
}

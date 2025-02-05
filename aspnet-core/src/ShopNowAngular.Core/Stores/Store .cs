using Abp.Domain.Entities.Auditing;
using ShopNowAngular.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.Stores
{
    [Table("stores", Schema = "Store")]
    public class Store : FullAuditedEntity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid OwnerId { get; set; } // Links to ABP Users table

        public ICollection<Product> Products { get; set; }

        public Store()
        {
            Products = new List<Product>();
        }
    }
}

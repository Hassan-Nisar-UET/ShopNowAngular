using Abp.Domain.Entities.Auditing;
using ShopNowAngular.Authorization.Users;
using ShopNowAngular.Stores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.Carts
{
    [Table("Carts", Schema = "Cart")]
    public class Cart : FullAuditedEntity<Guid>
    {
        public long CustomerId { get; set; }
        public User User { get; set; }
        public Guid StoreId { get; set; }

        public ICollection<CartItem> CartItems { get; set; }
    }
}

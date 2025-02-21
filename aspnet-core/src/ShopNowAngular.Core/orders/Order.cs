using Abp.Domain.Entities.Auditing;
using ShopNowAngular.Authorization.Users;
using ShopNowAngular.Enums;
using ShopNowAngular.Stores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.orders
{
    [Table("Orders", Schema = "Order")]
    public class Order : FullAuditedEntity<Guid>
    {
        public long CustomerId { get; set; }
        public User User { get; set; }
        public Guid StoreId { get; set; }

        public double TotalAmount { get; set; }
        public OrderStatus OrderStatus { get; set; } // Pending, Shipped, Delivered
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}

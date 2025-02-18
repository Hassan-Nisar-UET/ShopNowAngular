using Abp.Domain.Entities.Auditing;
using Microsoft.EntityFrameworkCore;
using ShopNowAngular.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.orders
{
    [Table("OrderItems", Schema = "Order")]
    public class OrderItem : FullAuditedEntity<Guid>
    {
        public Guid OrderId { get; set; }

        public Guid ProductId { get; set; }

        public double Quantity { get; set; }
    }
}

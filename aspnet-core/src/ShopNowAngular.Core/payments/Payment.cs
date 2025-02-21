using Abp.Domain.Entities.Auditing;
using Microsoft.EntityFrameworkCore;
using ShopNowAngular.Authorization.Users;
using ShopNowAngular.Enums;
using ShopNowAngular.orders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.payments
{
    [Table("Payments", Schema = "Payment")]
    public class Payment : FullAuditedEntity<Guid>
    {
        public Guid OrderId { get; set; }
        public long CustomerId { get; set; }
        public User User { get; set; }
        public double Amount { get; set; }
        public PaymentStatus PaymentStatus { get; set; }

        
    }
}

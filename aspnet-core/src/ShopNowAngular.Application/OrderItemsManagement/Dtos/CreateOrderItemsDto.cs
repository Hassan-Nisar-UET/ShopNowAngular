using Abp.AutoMapper;
using ShopNowAngular.Carts;
using ShopNowAngular.orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.OrderItemsManagement.Dtos
{
    [AutoMapTo(typeof(OrderItem))]

    public class CreateOrderItemsDto
    {
        public Guid OrderId { get; set; }

        public Guid ProductId { get; set; }

        public double Quantity { get; set; }
    }
}

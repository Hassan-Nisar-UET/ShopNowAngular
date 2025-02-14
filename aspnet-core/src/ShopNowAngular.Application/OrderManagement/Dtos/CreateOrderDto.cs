using Abp.AutoMapper;
using ShopNowAngular.Enums;
using ShopNowAngular.orders;
using ShopNowAngular.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.OrderManagement.Dtos
{
    [AutoMapTo(typeof(Order))]

    public class CreateOrderDto
    {
        public long UserId { get; set; }

        public Guid StoreId { get; set; }

        public double TotalAmount { get; set; }
        public OrderStatus OrderStatus { get; set; } 
    }
}

using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ShopNowAngular.Carts;
using ShopNowAngular.Enums;
using ShopNowAngular.orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.OrderManagement.Dtos
{
    [AutoMapTo(typeof(Order))]

    public class UpdateOrderDto:EntityDto<Guid>
    {
        public long UserId { get; set; }

        public Guid StoreId { get; set; }

        public double TotalAmount { get; set; }
        public OrderStatus OrderStatus { get; set; } 
    }
}

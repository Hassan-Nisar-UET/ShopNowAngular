using Abp.Application.Services.Dto;
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
    [AutoMapFrom(typeof(Order))]

    public class GetOrderDto:EntityDto<Guid>
    {
        public long UserId { get; set; }

        public Guid StoreId { get; set; }

        public double TotalAmount { get; set; }
        public OrderStatus OrderStatus { get; set; } 
    }
}

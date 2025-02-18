using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ShopNowAngular.Carts;
using ShopNowAngular.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.CartItemsManagement.Dtos
{
    [AutoMapFrom(typeof(CartItem))]

    public class GetCartItemsDto:EntityDto<Guid>
    {
        public Guid CartId { get; set; }
        public Guid ProductId { get; set; }
        public double Quantity { get; set; }
    }
}

using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ShopNowAngular.Carts;
using ShopNowAngular.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.CartManagement.Dtos
{
    [AutoMapFrom(typeof(Cart))]

    public class GetCartDto:EntityDto<Guid>
    {
        public long UserId { get; set; }
        public Guid StoreId { get; set; }
    }
}

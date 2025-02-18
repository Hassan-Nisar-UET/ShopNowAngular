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
    [AutoMapTo(typeof(Cart))]

    public class CreateCartDto
    {
        public long UserId { get; set; }
        public Guid StoreId { get; set; }
    }
}

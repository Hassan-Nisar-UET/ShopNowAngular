using Abp.Application.Services;
using ShopNowAngular.Categories.Dtos;
using ShopNowAngular.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.Products
{
    public interface IProductAppService : IAsyncCrudAppService<GetProductDto, Guid, PagedProductResultRequestDto, CreateProductDto, UpdateProductDto>
    {
    }
}

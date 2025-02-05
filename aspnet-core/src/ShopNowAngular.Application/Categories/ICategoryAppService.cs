using Abp.Application.Services;
using ShopNowAngular.Categories.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.Categories
{
    public interface ICategoryAppService : IAsyncCrudAppService<GetCategoryDto, Guid, PagedCategoryResultRequestDto, CreateCategoryDto, UpdateCategoryDto>
    {
    }
}

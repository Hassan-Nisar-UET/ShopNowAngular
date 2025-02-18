using Abp.Application.Services;
using ShopNowAngular.Categories.Dtos;
using ShopNowAngular.SubCategories.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.SubCategories
{
    public interface ISubCategoryAppService : IAsyncCrudAppService<GetSubCategoryDto, Guid, PagedSubCategoryResultRequestDto, CreateSubCategoryDto, UpdateSubCategoryDto>
    {
    }
}

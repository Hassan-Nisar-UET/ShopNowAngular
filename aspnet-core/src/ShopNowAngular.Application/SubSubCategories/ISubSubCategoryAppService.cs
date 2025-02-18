using Abp.Application.Services;
using ShopNowAngular.Categories.Dtos;
using ShopNowAngular.SubSubCategories.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.SubSubCategories
{
    public interface ISubSubCategoryAppService : IAsyncCrudAppService<GetSubSubCategoryDto, Guid, PagedSubSubCategoryResultRequestDto, CreateSubSubCategoryDto, UpdateSubSubCategoryDto>
    {
    }
}

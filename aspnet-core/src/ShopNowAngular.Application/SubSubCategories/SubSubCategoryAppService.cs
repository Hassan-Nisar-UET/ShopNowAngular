using Abp.Application.Services;
using ShopNowAngular.Categories.Dtos;
using ShopNowAngular.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopNowAngular.SubSubCategories.Dtos;
using Abp.Domain.Repositories;
using Abp.Application.Services.Dto;

namespace ShopNowAngular.SubSubCategories
{
    public class SubSubCategoryAppService : AsyncCrudAppService<Category, GetSubSubCategoryDto, Guid, PagedSubSubCategoryResultRequestDto, CreateSubSubCategoryDto, UpdateSubSubCategoryDto>, ISubSubCategoryAppService
    {
        public SubSubCategoryAppService(IRepository<Category, Guid> repository) : base(repository)
        {
        }

        public override Task<GetSubSubCategoryDto> CreateAsync(CreateSubSubCategoryDto input)
        {
            return base.CreateAsync(input);
        }

        public override Task DeleteAsync(EntityDto<Guid> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<GetSubSubCategoryDto>> GetAllAsync(PagedSubSubCategoryResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<GetSubSubCategoryDto> GetAsync(EntityDto<Guid> input)
        {
            return base.GetAsync(input);
        }

        public override Task<GetSubSubCategoryDto> UpdateAsync(UpdateSubSubCategoryDto input)
        {
            return base.UpdateAsync(input);
        }

        protected override Task<Category> GetEntityByIdAsync(Guid id)
        {
            return base.GetEntityByIdAsync(id);
        }
    }
}

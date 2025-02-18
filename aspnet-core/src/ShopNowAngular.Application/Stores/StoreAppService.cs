using Abp.Application.Services;
using ShopNowAngular.Categories.Dtos;
using ShopNowAngular.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopNowAngular.Stores.Dtos;
using Abp.Domain.Repositories;
using Abp.Application.Services.Dto;

namespace ShopNowAngular.Stores
{
    public class StoreAppService : AsyncCrudAppService<Store, GetStoreDto, Guid, PagedStoreResultRequestDto, CreateStoreDto, UpdateStoreDto>, IStoreAppService
    {
        public StoreAppService(IRepository<Store, Guid> repository) : base(repository)
        {
        }

        public override Task<GetStoreDto> CreateAsync(CreateStoreDto input)
        {
            return base.CreateAsync(input);
        }

        public override Task DeleteAsync(EntityDto<Guid> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<GetStoreDto>> GetAllAsync(PagedStoreResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<GetStoreDto> GetAsync(EntityDto<Guid> input)
        {
            return base.GetAsync(input);
        }

        public override Task<GetStoreDto> UpdateAsync(UpdateStoreDto input)
        {
            return base.UpdateAsync(input);
        }

        protected override Task<Store> GetEntityByIdAsync(Guid id)
        {
            return base.GetEntityByIdAsync(id);
        }
    }
}

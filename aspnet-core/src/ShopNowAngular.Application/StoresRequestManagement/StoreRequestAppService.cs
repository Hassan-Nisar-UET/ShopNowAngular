using Abp.Application.Services;
using ShopNowAngular.SubCategories.Dtos;
using ShopNowAngular.SubCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopNowAngular.StoreRequests;
using ShopNowAngular.StoresRequestManagement.Dtos;
using Abp.Domain.Repositories;
using Abp.Application.Services.Dto;

namespace ShopNowAngular.StoresRequestManagement
{
    public class StoreRequestAppService: AsyncCrudAppService<StoreRequest, GetStoreRequestDto, Guid, PagedStoreRequestResultRequestDto, CreateStoreRequestDto, UpdateStoreRequestDto>, IStoreRequestAppService
    {
        public StoreRequestAppService(IRepository<StoreRequest, Guid> repository) : base(repository)
        {
        }

        public override Task<GetStoreRequestDto> CreateAsync(CreateStoreRequestDto input)
        {
            return base.CreateAsync(input);
        }

        public override Task DeleteAsync(EntityDto<Guid> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<GetStoreRequestDto>> GetAllAsync(PagedStoreRequestResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<GetStoreRequestDto> GetAsync(EntityDto<Guid> input)
        {
            return base.GetAsync(input);
        }

        public override Task<GetStoreRequestDto> UpdateAsync(UpdateStoreRequestDto input)
        {
            return base.UpdateAsync(input);
        }
    }
}

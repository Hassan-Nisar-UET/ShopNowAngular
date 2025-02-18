using Abp.Application.Services;
using ShopNowAngular.Categories.Dtos;
using ShopNowAngular.Stores.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.Stores
{
    public interface IStoreAppService : IAsyncCrudAppService<GetStoreDto, Guid, PagedStoreResultRequestDto, CreateStoreDto, UpdateStoreDto>
    {
    }
}

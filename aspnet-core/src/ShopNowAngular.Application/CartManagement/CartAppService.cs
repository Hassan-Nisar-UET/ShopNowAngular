using Abp.Application.Services;
using ShopNowAngular.Categories.Dtos;
using ShopNowAngular.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopNowAngular.Carts;
using ShopNowAngular.CartManagement.Dtos;
using Abp.Domain.Repositories;
using Abp.Application.Services.Dto;

namespace ShopNowAngular.CartManagement
{
    public class CartAppService : AsyncCrudAppService<Cart, GetCartDto, Guid, PagedCartResultRequestDto, CreateCartDto, UpdateCartDto>, ICartAppService
    {
        public CartAppService(IRepository<Cart, Guid> repository) : base(repository)
        {
        }

        public override Task<GetCartDto> CreateAsync(CreateCartDto input)
        {
            return base.CreateAsync(input);
        }

        public override Task DeleteAsync(EntityDto<Guid> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<GetCartDto>> GetAllAsync(PagedCartResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<GetCartDto> GetAsync(EntityDto<Guid> input)
        {
            return base.GetAsync(input);
        }

        public override Task<GetCartDto> UpdateAsync(UpdateCartDto input)
        {
            return base.UpdateAsync(input);
        }
    }
}

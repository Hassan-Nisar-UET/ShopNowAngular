using Abp.Application.Services;
using Abp.Domain.Repositories;
using ShopNowAngular.CartItemsManagement.Dtos;
using ShopNowAngular.CartItemsManagement;
using ShopNowAngular.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopNowAngular.orders;
using ShopNowAngular.OrderManagement.Dtos;
using Abp.Application.Services.Dto;

namespace ShopNowAngular.OrderManagement
{
    public class OrderAppService : AsyncCrudAppService<Order, GetOrderDto, Guid, PagedOrderResultRequestDto, CreateOrderDto, UpdateOrderDto>, IOrderAppService
    {
        public OrderAppService(IRepository<Order, Guid> repository) : base(repository)
        {
        }

        public override Task<GetOrderDto> CreateAsync(CreateOrderDto input)
        {
            return base.CreateAsync(input);
        }

        public override Task DeleteAsync(EntityDto<Guid> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<GetOrderDto>> GetAllAsync(PagedOrderResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<GetOrderDto> GetAsync(EntityDto<Guid> input)
        {
            return base.GetAsync(input);
        }

        public override Task<GetOrderDto> UpdateAsync(UpdateOrderDto input)
        {
            return base.UpdateAsync(input);
        }
    }
    
}

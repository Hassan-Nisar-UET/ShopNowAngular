using Abp.Application.Services.Dto;
using Abp.Data;
using Abp.EntityFrameworkCore;
using ShopNowAngular.orders;
using ShopNowAngular.Repositories.OrderManagement.Orders.Dtos;
using ShopNowAngular.Repositories.StoreManagement.StoreRequests.Dtos;
using ShopNowAngular.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.EntityFrameworkCore.Repositories.OrderManagement.Orders
{
    public class OrderRepository : ShopNowAngularRepositoryBase<Order, Guid>
    {
        private readonly IDbContextProvider<ShopNowAngularDbContext> _dbContextProvider;
        private readonly IActiveTransactionProvider _transactionProvider;
        public OrderRepository(IDbContextProvider<ShopNowAngularDbContext> dbContextProvider, IActiveTransactionProvider transactionProvider) : base(dbContextProvider, transactionProvider)
        {
            _dbContextProvider = dbContextProvider;
            _transactionProvider = transactionProvider;
        }

        public async Task<PagedResultDto<GetOrderRequestSpDto>> GetAllOrders(PagedOrderRequestResultRequestSpDto input)
           => await ExecuteSearchStoreProcedure<PagedOrderRequestResultRequestSpDto, GetOrderRequestSpDto>(input, "[Order].[GetAllOrders]");


    }
}


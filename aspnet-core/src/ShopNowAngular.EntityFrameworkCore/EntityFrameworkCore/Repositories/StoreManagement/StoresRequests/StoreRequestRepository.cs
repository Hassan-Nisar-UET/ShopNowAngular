using Abp.Application.Services.Dto;
using Abp.Data;
using Abp.EntityFrameworkCore;
using ShopNowAngular.Repositories.StoreManagement.StoreRequests.Dtos;
using ShopNowAngular.Repositories.StoreManagement.Stores.Dtos;
using ShopNowAngular.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.EntityFrameworkCore.Repositories.StoreManagement.StoresRequests
{
    public class StoreRequestRepository : ShopNowAngularRepositoryBase<Store, Guid>
    {
        private readonly IDbContextProvider<ShopNowAngularDbContext> _dbContextProvider;
        private readonly IActiveTransactionProvider _transactionProvider;
        public StoreRequestRepository(IDbContextProvider<ShopNowAngularDbContext> dbContextProvider, IActiveTransactionProvider transactionProvider) : base(dbContextProvider, transactionProvider)
        {
            _dbContextProvider = dbContextProvider;
            _transactionProvider = transactionProvider;
        }

        public async Task<PagedResultDto<GetStoreRequestSpDto>> GetAllStoreRequests(PagedStoreRequestResultRequestSpDto input)
           => await ExecuteSearchStoreProcedure<PagedStoreRequestResultRequestSpDto, GetStoreRequestSpDto>(input, "[Store].[GetAllStoreRequests]");


    }
}
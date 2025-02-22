using Abp.Application.Services.Dto;
using Abp.Data;
using Abp.EntityFrameworkCore;
using ShopNowAngular.orders;
using ShopNowAngular.Repositories.ProductManagement.Categories.Dtos;
using ShopNowAngular.Repositories.ProductManagement.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.EntityFrameworkCore.Repositories.ProductManagement.Products
{
    public class ProductRepository : ShopNowAngularRepositoryBase<Order, Guid>
    {
        private readonly IDbContextProvider<ShopNowAngularDbContext> _dbContextProvider;
        private readonly IActiveTransactionProvider _transactionProvider;
        public ProductRepository(IDbContextProvider<ShopNowAngularDbContext> dbContextProvider, IActiveTransactionProvider transactionProvider) : base(dbContextProvider, transactionProvider)
        {
            _dbContextProvider = dbContextProvider;
            _transactionProvider = transactionProvider;
        }

        public async Task<PagedResultDto<GetProductsRequestSpDto>> GetAllProducts(PagedProductsRequestResultRequestSpDto input)
           => await ExecuteSearchStoreProcedure<PagedProductsRequestResultRequestSpDto, GetProductsRequestSpDto>(input, "[product].[GetAllProducts]");


    }
}
    

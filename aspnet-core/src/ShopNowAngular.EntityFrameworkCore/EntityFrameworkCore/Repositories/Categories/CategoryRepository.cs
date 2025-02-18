using Abp.Data;
using Abp.EntityFrameworkCore;
using ShopNowAngular.Categories;
using ShopNowAngular.Repositories.Categories;
using System;

namespace ShopNowAngular.EntityFrameworkCore.Repositories.Categories
{
    public class CategoryRepository : ShopNowAngularRepositoryBase<Category, Guid>, ICategoryRepository
    {
        private readonly IDbContextProvider<ShopNowAngularDbContext> _dbContextProvider;
        private readonly IActiveTransactionProvider _transactionProvider;
        public CategoryRepository(IDbContextProvider<ShopNowAngularDbContext> dbContextProvider, IActiveTransactionProvider transactionProvider) : base(dbContextProvider, transactionProvider)
        {
            _dbContextProvider = dbContextProvider;
            _transactionProvider = transactionProvider;
        }
    }
}

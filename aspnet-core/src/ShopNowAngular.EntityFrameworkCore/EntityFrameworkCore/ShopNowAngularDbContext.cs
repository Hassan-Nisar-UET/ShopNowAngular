using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ShopNowAngular.Authorization.Roles;
using ShopNowAngular.Authorization.Users;
using ShopNowAngular.MultiTenancy;
using ShopNowAngular.Categories;
using ShopNowAngular.Products;
using ShopNowAngular.Stores;
using ShopNowAngular.SubCategories;
using ShopNowAngular.SubSubCategories;

namespace ShopNowAngular.EntityFrameworkCore
{
    public class ShopNowAngularDbContext : AbpZeroDbContext<Tenant, Role, User, ShopNowAngularDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<SubSubCategory> SubSubCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
        public ShopNowAngularDbContext(DbContextOptions<ShopNowAngularDbContext> options)
            : base(options)
        {
        }
    }
}

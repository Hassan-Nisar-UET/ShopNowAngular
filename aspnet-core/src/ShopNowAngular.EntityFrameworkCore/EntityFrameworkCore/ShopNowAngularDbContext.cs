using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ShopNowAngular.Authorization.Roles;
using ShopNowAngular.Authorization.Users;
using ShopNowAngular.MultiTenancy;

namespace ShopNowAngular.EntityFrameworkCore
{
    public class ShopNowAngularDbContext : AbpZeroDbContext<Tenant, Role, User, ShopNowAngularDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ShopNowAngularDbContext(DbContextOptions<ShopNowAngularDbContext> options)
            : base(options)
        {
        }
    }
}

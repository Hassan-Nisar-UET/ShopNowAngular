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
using ShopNowAngular.Carts;
using ShopNowAngular.orders;
using ShopNowAngular.payments;
using ShopNowAngular.StoreRequests;


namespace ShopNowAngular.EntityFrameworkCore
{
    public class ShopNowAngularDbContext : AbpZeroDbContext<Tenant, Role, User, ShopNowAngularDbContext>
    {
        /* Define a DbSet for each entity of the application */

        



        // Product & Category Tables
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<SubSubCategory> SubSubCategories { get; set; }
        public DbSet<Product> Products { get; set; }

        // Store Management Tables
        public DbSet<StoreRequest> StoreRequests { get; set; }
        public DbSet<Store> Stores { get; set; }


        // Order & Cart Tables
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }


        // Payment Table
        public DbSet<Payment> Payments { get; set; }

        public ShopNowAngularDbContext(DbContextOptions<ShopNowAngularDbContext> options)
            : base(options)
        {
        }
    }
}

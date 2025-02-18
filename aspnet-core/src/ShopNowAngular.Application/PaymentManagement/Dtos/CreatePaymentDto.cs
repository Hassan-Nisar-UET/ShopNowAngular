using Abp.AutoMapper;
using ShopNowAngular.Categories;
using ShopNowAngular.Products;
using ShopNowAngular.Stores;
using ShopNowAngular.SubCategories;
using ShopNowAngular.SubSubCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.PaymentManagement.Dtos
{
    [AutoMapTo(typeof(Product))]

    public class CreatePaymentDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double StockQuantity { get; set; }
        public Guid CategoryId { get; set; }
        public Guid? SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public Guid? SubSubCategoryId { get; set; }
        public Guid StoreId { get; set; }
    }
}

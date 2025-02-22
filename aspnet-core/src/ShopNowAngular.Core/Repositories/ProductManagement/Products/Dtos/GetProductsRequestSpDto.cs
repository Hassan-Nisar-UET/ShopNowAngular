using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.Repositories.ProductManagement.Products.Dtos
{
    public class GetProductsRequestSpDto
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string SubCategory { get; set; }
        public string SubSubCategory { get; set; }
        public string CategoryName { get; set; }

    }
}

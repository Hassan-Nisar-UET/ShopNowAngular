using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.SubSubCategories.Dtos
{
    [AutoMapTo(typeof(SubSubCategory))]
    public class CreateSubSubCategoryDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid SubCategoryId { get; set; }
    }
}

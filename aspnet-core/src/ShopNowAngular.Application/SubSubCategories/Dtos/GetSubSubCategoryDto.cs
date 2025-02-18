using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.SubSubCategories.Dtos
{
    [AutoMapFrom(typeof(SubSubCategory))]
    public class GetSubSubCategoryDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid SubCategoryId { get; set; }
    }
}

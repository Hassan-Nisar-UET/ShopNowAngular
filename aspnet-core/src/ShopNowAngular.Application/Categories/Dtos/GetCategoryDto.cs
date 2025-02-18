using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.Categories.Dtos
{
    public class GetCategoryDto : EntityDto<Guid>
    {
        [AutoMapFrom(typeof(Category))]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

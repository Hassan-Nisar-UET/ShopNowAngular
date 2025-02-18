using Abp.Runtime.Validation;
using ShopNowAngular.Comman.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.OrderManagement.Dtos
{
    public class PagedOrderResultRequestDto : PagedAndSortedInputDto, IShouldNormalize
    {
        public string Keyword { get; set; }
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "creationTime desc";
            }

            Keyword = Keyword?.Trim();
        }
    }
}

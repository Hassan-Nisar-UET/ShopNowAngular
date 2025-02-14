using Abp.AutoMapper;
using ShopNowAngular.Authorization.Users;
using ShopNowAngular.Enums;
using ShopNowAngular.StoreRequests;
using ShopNowAngular.SubCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.StoresRequestManagement.Dtos
{
    [AutoMapTo(typeof(StoreRequest))]

    public class CreateStoreRequestDto
    {
        public string StoreName { get; set; }
        public long StoreOwnerId { get; set; }
        public User StoreOwner { get; set; }
        public StoreRequestStatus StorerequestStatus { get; set; }

    }
}

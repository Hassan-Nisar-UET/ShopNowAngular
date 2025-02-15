using Abp.Application.Services.Dto;
using ShopNowAngular.Authorization.Users;
using ShopNowAngular.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.StoresRequestManagement.Dtos
{
    public class UpdateStoreRequestDto:EntityDto<Guid>
    {
        public string StoreName { get; set; }
        public long StoreOwnerId { get; set; }
        public User StoreOwner { get; set; }
        public StoreRequestStatus StorerequestStatus { get; set; }
    }
}

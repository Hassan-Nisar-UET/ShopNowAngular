using Abp.Authorization.Users;
using ShopNowAngular.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.Authorization.Users
{
    public class UserExtension : AbpUser<User>
    {
        public UserType UserType { get; set; }
        public string EmailCodeVerification { get; set; }
        public DateTime? EmailCodeSendingTime { get; set; }
    }
}

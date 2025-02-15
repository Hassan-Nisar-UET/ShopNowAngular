using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.Enums
{
    public enum UserType
    {

        [Description("Admin")]
        Admin,

        [Description("StoreOwner")]
        StoreOwner,

        [Description("Customer")]
        Customer
    }
}

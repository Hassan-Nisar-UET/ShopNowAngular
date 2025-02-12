using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.Enums
{
    public enum OrderStatus
    {
        [Description("Pending")]
        Pending,
        [Description("Processing")]
        Processing,
        [Description("Shipped")]
        Shipped,
        [Description("Delivered")]
        Delivered,


    }
}

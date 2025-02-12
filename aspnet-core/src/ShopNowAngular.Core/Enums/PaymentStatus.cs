using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.Enums
{
    public enum PaymentStatus
    {
        [Description("Pending")]
        Pending,
        [Description("Completed")]
        Completed,
        [Description("Failed")]
        Failed,


    }
}

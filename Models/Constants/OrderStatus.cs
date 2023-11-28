using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bakery.Models.Constants
{
    internal enum OrderStatus
    {
        Pending = 1,
        Processing = 2,
        Completed = 3,
        Delivered = 4,
        Canceled = 5
    }
}

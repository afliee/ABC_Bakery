
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bakery.Models.Constants
{
    internal enum OrderType
    {
        Paid = 1,
        Unpaid = 2,
        Prepay = 3,
        Canceled = 4,
        Refunded = 5,
        Completed = 6
    }
}

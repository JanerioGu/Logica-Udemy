﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_24_Udemy_Enum.Entities.Enums
{
    internal enum OrderStatus : int
    {
        PendingPayament = 0,
        Processing = 1,
        Shipped = 2,
        Devired = 3,
    }
}

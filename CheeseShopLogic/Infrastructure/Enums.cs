﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CheeseShopLogic.Infrastructure
{
    public enum Status
    {
        Received,
        Dispatched,
        Delivered
    }

    public enum DeliveryMethod
    {
        NextDay,
        Standard,
        Free
    }
}

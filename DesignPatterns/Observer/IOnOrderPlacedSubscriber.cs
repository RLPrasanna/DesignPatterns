using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    internal interface IOnOrderPlacedSubscriber
    {
        void announceOrderPlaced();
    }
}

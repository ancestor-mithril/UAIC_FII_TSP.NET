using System;
using System.Collections.Generic;
using System.Linq;
using TSP.NET.L2;

namespace TSP.NET.L2.Refactored
{
    class CashController
    {
        private decimal _cashAccepted;

        public void Charge(TicketDetails ticket)
        {
            var r = new Random();
            _cashAccepted = r.Next((int)ticket.Price, (int)ticket.Price + 1000);
        }

        private bool TryToDispense(decimal changeAmount)
        {
            return false;
        }

    }
}

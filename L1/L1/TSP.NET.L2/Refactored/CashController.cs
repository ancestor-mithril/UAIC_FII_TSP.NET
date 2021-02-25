using System;

namespace TSP.NET.L2.Refactored
{
    class CashController : IPaymentController
    {
        private decimal _cashAccepted;

        public void Charge(TicketDetails ticket, PaymentDetails details)
        {
            var r = new Random();
            _cashAccepted = r.Next((int)ticket.Price, (int)ticket.Price + 1000);
            DispenseChange(ticket, details);
        }

        private void DispenseChange(TicketDetails ticket, PaymentDetails details)
        {
            if (_cashAccepted > ticket.Price &&
                !TryToDispense(_cashAccepted - ticket.Price))
                details.OnPayChangeToMobilePhone?.Invoke();
        }

        private bool TryToDispense(decimal changeAmount)
        {
            return true; // false if the customer hates pennies
        }
    }
}

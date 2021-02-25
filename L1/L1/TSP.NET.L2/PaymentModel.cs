using TSP.NET.L2.Refactored;

namespace TSP.NET.L2
{

    public class PaymentModel
    {
        public void BuyTicket(TicketDetails ticket, PaymentDetails payment)
        {
            IPaymentController paymentControler;

            if (payment.Method == PaymentMethod.CreditCard)
            {
                paymentControler = new CardController();
            }
            else
            {
                paymentControler = new CashController();
            }
            paymentControler.Charge(ticket, payment);
        }
    }
}

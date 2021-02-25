namespace TSP.NET.L2.Refactored
{
    interface IPaymentController
    {
        public void Charge(TicketDetails ticketDetails, PaymentDetails payment);
    }
}

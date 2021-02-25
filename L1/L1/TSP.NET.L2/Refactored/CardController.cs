namespace TSP.NET.L2.Refactored
{
    class CardController : IPaymentController
    {
        public void Charge(TicketDetails ticketDetails, PaymentDetails payment)
        {
            var gateway = new ProcessingCenterGateway();
            gateway.Charge(ticketDetails.Price, payment);
        }
    }

    internal class ProcessingCenterGateway
    {
        public void Charge(decimal ticketPrice, PaymentDetails paymentDetails)
        {
            //charging process
        }
    }
}

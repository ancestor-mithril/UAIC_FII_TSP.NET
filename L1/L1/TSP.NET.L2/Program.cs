namespace TSP.NET.L2
{
    class Program
    {
        public static void Main()
        {
            TicketDetails ticket = new TicketDetails(1000m);

            PaymentDetails payment = new PaymentDetails(PaymentMethod.Cash);

            PaymentModel pM = new PaymentModel();
            pM.BuyTicket(ticket, payment, null);
        }
    }
}

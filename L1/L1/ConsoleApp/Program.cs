using System;
using TSP.NET.L2;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            var ticket = new TicketDetails(1000m);

            var payment = new PaymentDetails(PaymentMethod.CreditCard);

            var pM = new PaymentModel();

            pM.BuyTicket(ticket, payment);
        }
    }
}

using System;


namespace TSP.NET.L2
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("da");
            TicketDetails ticket = new TicketDetails();
            ticket.Price = 1000m;
            PaymentModel pM = new PaymentModel();
            PaymentDetails payment = new PaymentDetails();
            payment.Method = PaymentMethod.CreditCard;
            Action action = null;
            

            Console.WriteLine("Hello World!");
            Console.WriteLine(ticket.Price);

            
            pM.BuyTicket(ticket, payment, action);
            Console.WriteLine("a");
        }
    }
}

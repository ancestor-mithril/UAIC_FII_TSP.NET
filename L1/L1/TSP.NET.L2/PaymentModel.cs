﻿using System;
using TSP.NET.L2.Refactored;

namespace TSP.NET.L2
{

    public class PaymentModel
    {
        private decimal _cashAccepted;

        public void BuyTicket(TicketDetails ticket,
                              PaymentDetails payment, Action onPayChangeToMobilePhone)
        {
            if (payment.Method == PaymentMethod.CreditCard)
            {
                ChargeCard(ticket, payment);
            }
            else
            {
                AcceptCash(ticket);
                DispenseChange(ticket, onPayChangeToMobilePhone);
            }
        }

        private void ChargeCard(TicketDetails ticket, PaymentDetails payment)
        {
            var gateway = new ProcessingCenterGateway();
            gateway.Charge(ticket.Price, payment);
        }

        private void AcceptCash(TicketDetails ticket)
        {
            var cashController = new CashController();
            _cashAccepted = cashController.Charge(ticket);
        }

        private void DispenseChange(TicketDetails ticket, Action onPayChangeToMobilePhone)
        {
            if (_cashAccepted > ticket.Price &&
                !TryToDispense(_cashAccepted - ticket.Price))
                onPayChangeToMobilePhone?.Invoke();
        }

        private bool TryToDispense(decimal changeAmount)
        {
            return false; 
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
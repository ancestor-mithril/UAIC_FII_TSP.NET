using System;

namespace TSP.NET.L2
{
    public class PaymentDetails
    {
        public Action OnPayChangeToMobilePhone;
        public PaymentMethod Method { get; set; }

        public PaymentDetails(PaymentMethod method, Action onPayChangeToMobilePhone= null)
        {
            Method = method;
            OnPayChangeToMobilePhone = onPayChangeToMobilePhone;
        }
    }
}
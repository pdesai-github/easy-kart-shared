using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EasyKart.Shared.Models.Payment
{
    public class CreditCard : IPayment
    {
        private readonly PaymentMethod _paymentMethod;

        public PaymentMethod PaymentMethod => _paymentMethod;

        public CreditCard()
        {
            _paymentMethod = PaymentMethod.CreditCard;
        }

        public bool MakePayment(decimal amount)
        {
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyKart.Shared.Models.Payment
{
    public class Upi : IPayment
    {
        private readonly PaymentMethod _paymentMethod;
        public PaymentMethod PaymentMethod => _paymentMethod;
        public Upi()
        {
            _paymentMethod = PaymentMethod.Upi;
        }
        public bool MakePayment(decimal amount)
        {
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyKart.Shared.Models.Payment
{
    public class Cash : IPayment
    {
        private readonly PaymentMethod _paymentMethod;
        public PaymentMethod PaymentMethod => _paymentMethod;
        public Cash()
        {
            _paymentMethod = PaymentMethod.Cash;
        }
        public bool MakePayment(decimal amount)
        {
            return true;
        }
    }
}

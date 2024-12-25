

namespace EasyKart.Shared.Models
{
    public interface IPayment
    {
        PaymentMethod PaymentMethod { get; }

        bool MakePayment(decimal amount);

    }
}

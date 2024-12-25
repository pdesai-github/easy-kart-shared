using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EasyKart.Shared.Models
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public List<CartItem> Items { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required]
        public Address Address { get; set; }

        [Required]
        public IPayment PaymentMethod { get; set; }

        [Required]
        public OrderStatus Status { get; set; }

    }
}

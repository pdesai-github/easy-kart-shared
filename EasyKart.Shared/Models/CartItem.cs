using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace EasyKart.Shared.Models
{
    public class CartItem
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid OrderId { get; set; }

        [Required]
        public Product Product { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}

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
        public decimal Price { get; set; }       
        
        public string Status { get; set; }

    }
}

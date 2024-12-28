using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EasyKart.Shared.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Guid OrderId { get; set; } // Foreign key to Order table
        [Required]
        public Guid ProductId { get; set; } // Dictionary key
        [Required]
        public int Quantity { get; set; } // Dictionary value
        
        [JsonIgnore]
        public Order Order { get; set; }
    }
}

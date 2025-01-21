using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EasyKart.Shared.Models
{
    public class Order
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [Required]
        public List<OrderItem> Items { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public string Status { get; set; }

        public Order()
        {
            
        }
        public Order(Guid userId, Cart cart)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            Items = new List<OrderItem>();
            Price = cart.Price;
            CreatedDate = DateTime.Now;
            Status = "Pending";
            AddItems(cart);
        }

        public void AddItems(Cart cart)
        {
           cart.Items.ForEach(item =>
           {
               Items.Add(new OrderItem
               {
                   ProductId = item.Product.Id,
                   Quantity = item.Quantity
               });
           });
        }

        public void UpdateStatus(string status)
        {
            Status = status;
        }

    }
}

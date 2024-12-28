using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EasyKart.Shared.Models
{
    public class Order
    {
        [Key]
        public Guid Id { get; private set; }

        [Required]
        public List<OrderItem> Items { get; private set; }

        [Required]
        public Guid UserId { get; private set; }

        [Required]
        public decimal Price { get; private set; }

        [Required]
        public DateTime CreatedDate { get; private set; }

        public string Status { get; private set; }

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


using Newtonsoft.Json;

namespace EasyKart.Shared.Models
{
    public class Cart
    {
        [JsonProperty("id")]
        public Guid Id { get; private set; }

        [JsonProperty("items")]
        public List<CartItem> Items { get; private set; }

        [JsonProperty("userId")]
        public Guid UserId { get; private set; }

        [JsonProperty("price")]
        public decimal Price { get; private set; }

        public Cart(Guid userId)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            Items = new List<CartItem>();
            Price = 0;
        }

        public void calculatePrice()
        {
            Price = Items.Sum(item => item.Product.Price * item.Quantity);
        }

        public void addProduct(Product product, int quantity)
        {
            var item = Items.FirstOrDefault(i => i.Product.Id == product.Id);
            if (item == null)
            {
                Items.Add(new CartItem
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                item.Quantity += quantity;
            }
            calculatePrice();
        }

        public void removeProduct(Product product)
        {
            var item = Items.FirstOrDefault(i => i.Product.Id == product.Id);
            if (item != null)
            {
                Items.Remove(item);
                calculatePrice();
            }
        }
    }
}

using Newtonsoft.Json;

namespace EasyKart.Shared.Models
{
    public class Notification
    {
        public Guid Id { get; set; }        
        public string Title { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public Guid UserId { get; set; }
    }
}

using EasyKart.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyKart.Shared.Events
{
    public class OrderCreated
    {
        public DateTime CreatedAt { get; set; }
        public Order Order { get; set; }
    }
}

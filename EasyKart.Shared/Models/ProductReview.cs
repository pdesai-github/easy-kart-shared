
using Newtonsoft.Json;

namespace EasyKart.Shared.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    namespace EasyKart.Shared.Models
    {      
        public class ProductReview
        {
            [Key]
            public Guid Id { get; set; }

            [Required]
            public Guid ProductId { get; set; }

            [Required]
            public Guid UserId { get; set; }

            [Required]
            [MaxLength(100)]
            public string UserName { get; set; }

            [Required]
            [MaxLength(200)]
            public string Title { get; set; }

            [Required]
            [MaxLength(1000)]
            public string Review { get; set; }

            [Required]
            [Range(1, 5)]
            public int Rating { get; set; }
        }
    }

}

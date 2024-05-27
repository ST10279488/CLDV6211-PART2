using System.ComponentModel.DataAnnotations;

namespace khumaloCrafts.Models.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        

            [Required]
            [StringLength(100)]
            public required string CustomerName { get; set; }

            public DateTime OrderDate { get; set; } = DateTime.Now;

            [StringLength(500)]
            public required string Address { get; set; }
        }
    }


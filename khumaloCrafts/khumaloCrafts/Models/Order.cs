namespace khumaloCrafts.Models
{
    public class Order
    {
        
            public int OrderId { get; set; }
            public int UserId { get; set; }
            public  required User User { get; set; }
            public DateTime OrderDate { get; set; }
        }

    }


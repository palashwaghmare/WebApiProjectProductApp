using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebApiProject.AppDbContext
{
    public class Bookings
    {
        [Key]
        public int BookingId { get; set; }

        public string BookingCity { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        [JsonIgnore]
        public Product Products { get; set; }
        
        


    }
}

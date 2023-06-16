using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiProject.Model
{
    public class GetBookingDTO
    {

        public int BookingId { get; set; }

        public string BookingCity { get; set; }

        public int ProductId { get; set; }
    }
}

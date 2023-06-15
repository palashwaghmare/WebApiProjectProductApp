using System.ComponentModel.DataAnnotations;

namespace WebApiProject.AppDbContext
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public string ProductDescription { get; set; } 
        public string ProductCategory { get; set; }
       
        public DateTime MfdDate { get; set; }

        public double ProductPrice { get; set; }

       
      

        public ICollection<Bookings> bookings { get; set; }

    }
}

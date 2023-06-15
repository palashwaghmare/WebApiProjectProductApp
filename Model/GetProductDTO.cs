namespace WebApiProject.Model
{
    public class GetProductDTO
    {

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }
        public string ProductCategory { get; set; }

        public DateTime MfdDate { get; set; }

        public double ProductPrice { get; set; }
    }
}

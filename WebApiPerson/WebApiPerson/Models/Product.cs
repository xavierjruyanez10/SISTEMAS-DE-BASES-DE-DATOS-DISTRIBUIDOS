namespace WebApiPerson.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        // Clasificación por precio
        public string PriceCategory =>
            Price < 20 ? "Bajo" :
            Price <= 50 ? "Medio" : "Alto";
    }
}

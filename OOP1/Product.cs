using System.Text.Json;

namespace OOP1
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        //ürün ismi
        public string ProductName { get; set; }
        //birim fiyatı
        public double UnitPrice { get; set; }
        //stokdaki birim adedi
        public int UnitsInStock { get; set; }
        
    }
}
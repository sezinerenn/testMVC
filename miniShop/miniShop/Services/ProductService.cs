using miniShop.Models;

namespace miniShop.Services
{
    public class ProductService
    {
        public List<Product> GetProducts()
        {
            var products = new List<Product>()
            {
                new(){ Id=1, Name="Çikolata", Price=20, Description="Sütlü..."},
                new(){ Id=2, Name="Gözlük", Price=20, Description="aaa..."},
                new(){ Id=3, Name="Pijama", Price=20, Description="bbb..."},
                new(){ Id=4, Name="Elfeneri", Price=20, Description="ccc..."},

            };

            return products;
        }
    }
}

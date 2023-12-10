namespace miniShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; } = "https://cdn.dsmcdn.com/ty1009/product/media/images/prod/SPM/PIM/20231005/15/d5005d40-0165-3780-a906-10b116cca633/1_org_zoom.jpg";

    }
}

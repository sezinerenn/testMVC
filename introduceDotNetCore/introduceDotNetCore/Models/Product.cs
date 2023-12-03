using System.ComponentModel.DataAnnotations;

namespace introduceDotNetCore.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ürün Adı boş olamaz")]
        [Display(Name = "Ürün Adı")]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

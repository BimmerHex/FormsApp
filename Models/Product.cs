using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name = "Ürün ID")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Ürün adı zorunlu bir alandır.")]
        [StringLength(60, ErrorMessage = "{0} {2} ile {1} arasında bir uzunlukta olması gerekmektedir.", MinimumLength = 3)]
        [Display(Name = "Ürün Adı")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Fiyat zorunlu bir alandır.")]
        [Range(0, 100000000)]
        [Display(Name = "Fiyat")]
        public decimal? Price { get; set; }

        [Display(Name = "Resim")]
        public string? Image { get; set; } = string.Empty;

        [Display(Name = "Aktif?")]
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "Kategori zorunlu bir alandır.")]
        [Display(Name = "Kategori")]
        public int CategoryId { get; set; }
    }
}
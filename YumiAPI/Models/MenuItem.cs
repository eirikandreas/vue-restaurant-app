using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace YumiAPI.Models{

    public class MenuItem{
      
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Ingredients { get; set; }
        public string Allergens { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public string ImgSrc { get; set; }
        public double Rating { get; set; }
        public string DateAdded { get; set; }
        public bool IsSpicy { get; set; }
        public bool IsFeatured { get; set; }
        
    }
}
using System.ComponentModel.DataAnnotations;

namespace YumiAPI.Models{
    public class MenuItem{
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Ingredients { get; set; }
        public string Allergens { get; set; }
        public string Price { get; set; }
        public string Category { get; set; }
        public string ImgUrl { get; set; }
        public string Rating { get; set; }
        public string TimesOrdered { get; set; }
        public string DateAdded { get; set; }
        public string IsFeatured { get; set; }
        
    }
}
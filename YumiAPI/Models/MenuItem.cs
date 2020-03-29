using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace YumiAPI.Models{

    public class MenuItem{
        private string _stringZero = "0";
      
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Ingredients { get; set; }
        public string Allergens { get; set; }
        public string Price { get; set; }
        public string Category { get; set; }
        public string ImgUrl { get; set; }
        public string Rating { get; set; }
        [DefaultValue("0")]
        public string TimesOrdered { get { return _stringZero; } set { _stringZero = value;} }
        public string DateAdded { get; set; }
        public string IsFeatured { get; set; }
        
    }
}
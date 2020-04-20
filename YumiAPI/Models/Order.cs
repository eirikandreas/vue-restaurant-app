using System.ComponentModel.DataAnnotations;

namespace YumiAPI.Models{
    public class Order{
        [Key]
        public int Id { get; set; }
        public string Items { get; set; }
        public int TotalPrice { get; set; }
        public string Comments { get; set; }
        public string DateAdded { get; set; }
        public string IsFinished { get; set; }
        
    }
}
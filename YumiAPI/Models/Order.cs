using System.ComponentModel.DataAnnotations;

namespace YumiAPI.Models{
    public class Order{
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Quantity { get; set; }
        public string Comments { get; set; }
        public string Estimate { get; set; }
        public string Delivered { get; set; }
        public string OrderCount { get; set; }
        public string IsFinished { get; set; }
        
    }
}
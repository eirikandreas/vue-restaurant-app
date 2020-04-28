using System.ComponentModel.DataAnnotations;

namespace YumiAPI.Models{
    public class Order{
        [Key]
        public int Id { get; set; }

        public string Items { get; set;}

        public int TotalPrice { get; set;}

        public string Name { get; set; }

        public string Email { get; set; }

        public int PhoneNumber { get; set; }

        public string Address { get; set; }

        public string Comment { get; set; }

        public string DateAdded { get; set; }
        
    }
}
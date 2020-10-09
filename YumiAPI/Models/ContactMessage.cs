using System.ComponentModel.DataAnnotations;

namespace YumiAPI.Models{
    public class ContactMessage{
        [Key]
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Comment { get; set; }
        public string DateSent { get; set; }
        public bool ContactByPhone { get; set; }
        public bool IsRead { get; set; }

    }
}
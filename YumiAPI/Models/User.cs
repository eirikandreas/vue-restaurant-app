using System.ComponentModel.DataAnnotations;

namespace YumiAPI.Models{
    public class User{
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string IsAdmin { get; set; }
        public string OrderCount { get; set; }
        public string LoggedIn { get; set; }
        public string UserImg { get; set; }
        public string DateRegistered { get; set; }
    }
}
namespace BaiTapVN.Models
{
    public class RegisterModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}

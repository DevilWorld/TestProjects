using System.ComponentModel.DataAnnotations;

namespace LoginSample.Models
{
    public class User
    {
        [Required]
        [Display(Name = "User ID")]
        public string UserID { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public bool IsValid(string UserId, string Password)
        {
            if (UserID == "Test" && Password == "TestPwd")
            {
                return true;
            }

            return false;
        }
    }
}
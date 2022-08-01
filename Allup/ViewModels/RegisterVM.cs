using System.ComponentModel.DataAnnotations;

namespace Allup.ViewModels
{
    public class RegisterVM
    {
        [Required,StringLength(20)]
        public string FirstName{ get; set; }

        [Required, StringLength(20)]
        public string LastName { get; set; }

        [Required, StringLength(30)]
        public string Username { get; set; }

        [Required]
        public int Age { get; set; }

        [Required,DataType(DataType.EmailAddress),StringLength(30)]
        public string Email { get; set; }

        [Required,DataType(DataType.Password)]
        public string Password { get; set; }

        [Required,DataType(DataType.Password), Compare(nameof(Password))]
        public string RepeatPassword { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace ContactManager.Models
{
    public class Contact
    {
        [Key] // This attribute denotes the property as the primary key
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a last name.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a phone number.")]
        [RegularExpression(@"^[0-9]{10,12}$", ErrorMessage = "Phone number must be between 10 and 12 digits.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter an email.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        public string Slug => $"{FirstName?.ToLower()}-{LastName?.ToLower()}";
    }
}

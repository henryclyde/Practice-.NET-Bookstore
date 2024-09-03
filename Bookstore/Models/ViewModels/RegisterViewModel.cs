using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models
{
    public class RegisterViewModel
    {
        // required field, username needed, up to length 255 characters
        [Required(ErrorMessage = "Please enter a username.")]
        [StringLength(255)]
        public string Username { get; set; } = string.Empty; // username variable

        [Required(ErrorMessage = "Please enter a password.")] // required field, with error message if no password is given
        [DataType(DataType.Password)] // sets to datatype.password
        [Compare("ConfirmPassword")] // make sure it matches the confirm password field
        public string Password { get; set; } = string.Empty; // password variable, string

        [Required(ErrorMessage = "Please confirm your password.")] // required field
        [DataType(DataType.Password)] // set to datatype of datatype.password
        [Display(Name = "Confirm Password")] // displays "confirm password
        public string ConfirmPassword { get; set; } = string.Empty; // variable for confirmed password
    }
}
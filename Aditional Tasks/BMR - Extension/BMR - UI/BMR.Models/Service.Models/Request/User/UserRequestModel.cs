namespace BMR.Models.Service.Models.Request
{
    using System.ComponentModel.DataAnnotations;

    public class UserRequestModel
    {
        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

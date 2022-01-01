namespace BMR.Models.Service.Models.Request.BMR
{
    using global::BMR.Models.Enums;

    using System.ComponentModel.DataAnnotations;

    public class CalculateBMRRequestModel
    {
        public long UserId { get; set; }
        [Required]
        public Gender Gender { get; set; }

        [Required]
        [Range(Constans.Constans.PersonConstants.MIN_AGE, Constans.Constans.PersonConstants.MAX_AGE, ErrorMessage = "Age must be between {2} and {1}.")]
        public byte Age { get; set; }

        [Required]
        [Range(Constans.Constans.PersonConstants.MIN_HEIGHT, Constans.Constans.PersonConstants.MAX_HEIGHT, ErrorMessage = "Height must be between {2} and {1}.")]
        public double Height { get; set; }

        [Required]
        [Range(Constans.Constans.PersonConstants.MIN_WEIGHT, Constans.Constans.PersonConstants.MAX_WEIGHT, ErrorMessage = "Weight must be between {2} and {1}.")]
        public double Weight { get; set; }

        [Required]
        public long Activity { get; set; }

        public string BuildMethod { get; set; }
    }
}
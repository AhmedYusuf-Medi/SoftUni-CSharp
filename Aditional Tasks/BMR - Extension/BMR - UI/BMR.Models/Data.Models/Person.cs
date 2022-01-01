namespace BMR.Models.Data.Models
{
    using BMR.Models.Data.Models.Common;

    using System;
    using System.ComponentModel.DataAnnotations;

    public abstract class Person : Entity
    {
        [Required, Range(Constans.Constans.PersonConstants.MIN_AGE, Constans.Constans.PersonConstants.MAX_AGE, ErrorMessage = "Age must be between {2} and {1}.")]
        public byte Age { get; set; }

        [Required, Range(Constans.Constans.PersonConstants.MIN_HEIGHT, Constans.Constans.PersonConstants.MAX_HEIGHT, ErrorMessage = "Height must be between {2} and {1}.")]
        public double Height { get; set; }

        [Required, Range(Constans.Constans.PersonConstants.MIN_WEIGHT, Constans.Constans.PersonConstants.MAX_WEIGHT, ErrorMessage = "Weight must be between {2} and {1}.")]
        public double Weight { get; set; }
    }
}
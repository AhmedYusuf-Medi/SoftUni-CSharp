namespace BMR.Models.Data.Models
{
    using BMR.Models.Data.Models.Common;

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class User : Entity, IDeletableEntity
    {
        public User()
        {
            this.BMRS = new HashSet<BasalMetabolicRate>();
        }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }

        [EmailAddress(ErrorMessage = "Email should be valid.")]
        public string Email { get; set; }

        [StringLength(100, ErrorMessage = "Password must be between {2} and {1}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public virtual ICollection<BasalMetabolicRate> BMRS { get; set; }
    }
}
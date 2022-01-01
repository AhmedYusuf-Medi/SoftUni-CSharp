namespace BMR.Models.Data.Models
{
    using BMR.Models.Data.Models.Common;
    using BMR.Models.Enums;

    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class BasalMetabolicRate : Person, IDeletableEntity
    {
        public double BMR { get; set; }

        public double BMRWithActivity { get; set; }

        public Gender Gender { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public long UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        public long ActivityId { get; set; }

        [ForeignKey(nameof(ActivityId))]
        public Activity Activity { get; set; }
    }
}
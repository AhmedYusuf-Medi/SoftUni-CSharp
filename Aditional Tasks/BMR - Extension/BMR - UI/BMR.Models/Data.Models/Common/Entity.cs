namespace BMR.Models.Data.Models.Common
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public abstract class Entity
    {
        [Key]
        public long Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}

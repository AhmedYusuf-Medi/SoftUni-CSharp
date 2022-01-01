namespace BMR.Models.Data.Models
{
    using BMR.Models.Data.Models.Common;

    using System.Collections.Generic;

    public class Activity : Entity
    {
        public Activity()
        {
            this.BMRS = new HashSet<BasalMetabolicRate>();
        }

        public string Name { get; set; }

        public virtual ICollection<BasalMetabolicRate> BMRS { get; set; }
    }
}

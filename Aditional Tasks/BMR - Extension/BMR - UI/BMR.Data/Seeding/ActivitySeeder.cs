namespace BMR.Data.Seeding
{
    using BMR.Models.Data.Models;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ActivitySeeder : ISeeder
    {
        public async Task SeedAsync(BMRDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Activities.Any())
            {
                return;
            }

            var activities = new List<string>
            {
               "Little No Exercise",
               "Light Exercise",
               "Moderate Exercise",
               "Very Active",
               "Extra  Active"
            };

            foreach (var activity in activities)
            {
                await dbContext.Activities.AddAsync(new Activity
                {
                    Name = activity
                });
            }
        }
    }
}

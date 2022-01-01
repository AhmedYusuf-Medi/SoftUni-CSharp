namespace BMR.Data.Seeding
{
    using BMR.Models.Data.Models;
    using BMR.Models.Enums;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class BMRSeeder : ISeeder
    {
        public async Task SeedAsync(BMRDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.BMRS.Any())
            {
                return;
            }

            var bmrs = new List<(double BMR, double BMRWithActivity, Gender Gender, byte Age, double Height, double Weight, long UserId,long ActivityId)>
            {
                (1.830,2.516,Gender.Male,20,180,80,1,1),
                (1.830,2.516,Gender.Male,20,180,80,2,1),
                (1.339,1.841,Gender.Female,20,160,60,1,1),
                (1.339,1.841,Gender.Female,20,160,60,1,1),
            };

            foreach (var bmr in bmrs)
            {
                await dbContext.BMRS.AddAsync(new BasalMetabolicRate
                {
                    BMR = bmr.BMR,
                    BMRWithActivity = bmr.BMRWithActivity,
                    Gender = bmr.Gender,
                    Age = bmr.Age,
                    Height = bmr.Height,
                    Weight = bmr.Weight,
                    UserId = bmr.UserId,
                    ActivityId = bmr.ActivityId
                });
            }
        }
    }
}
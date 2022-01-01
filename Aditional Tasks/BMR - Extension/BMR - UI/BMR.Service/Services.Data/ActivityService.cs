namespace BMR.Service.Services.Data
{
    using BMR.Data;
    using BMR.Models.Service.Models.Response.Activity;
    using BMR.Service.Contracts;

    using Microsoft.EntityFrameworkCore;

    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ActivityService : IActivityService
    {
        private readonly BMRDbContext db;

        public ActivityService(BMRDbContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<GetActivitiesResponseModel>> GetActivities()
        {
            return await this.db.Activities.Select(a => new GetActivitiesResponseModel
                                            {
                                               Id = a.Id,
                                               Name = a.Name
                                            }).ToListAsync();
        }
    }
}

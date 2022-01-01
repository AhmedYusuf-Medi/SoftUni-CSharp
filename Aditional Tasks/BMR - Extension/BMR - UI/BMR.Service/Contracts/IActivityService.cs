namespace BMR.Service.Contracts
{
    using BMR.Models.Service.Models.Response.Activity;

    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IActivityService
    {
        public Task<IEnumerable<GetActivitiesResponseModel>> GetActivities();
    }
}

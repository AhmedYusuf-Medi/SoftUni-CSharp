namespace BMR.Service.Contracts
{
    using BMR.Models.Service.Models.Request.BMR;
    using BMR.Models.Service.Models.Response.BMR;

    using System.Threading.Tasks;

    public interface IBMRService
    {
        public Task<CalculateBMRResponseModel> CalculateBMR(CalculateBMRRequestModel parameters, string Email);

        public double GetFamaleBMR(CalculateBMRRequestModel parameters);

        public double GetMaleBMR(CalculateBMRRequestModel parameters);

        public double CalculateBMRAfterGettingActivity(long activity);
    }
}
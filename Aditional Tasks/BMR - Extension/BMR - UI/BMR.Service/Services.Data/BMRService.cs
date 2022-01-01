namespace BMR.Service.Services.Data
{
    using BMR.Data.Common;
    using BMR.Models.Constans;
    using BMR.Models.Data.Models;
    using BMR.Models.Enums;
    using BMR.Models.Service.Models.Request.BMR;
    using BMR.Models.Service.Models.Response.BMR;
    using BMR.Service.Common;
    using BMR.Service.Contracts;

    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Threading.Tasks;

    public class BMRService : IBMRService
    {
        private readonly IDeletableEntityRepository<BasalMetabolicRate> bmrRepository;
        private readonly IDeletableEntityRepository<User> userRepository;

        private BasalMetabolicRate bmr;

        public BMRService(IDeletableEntityRepository<BasalMetabolicRate> bmrRepository
                         ,IDeletableEntityRepository<User> userRepository)
        {
            this.bmrRepository = bmrRepository;
            this.userRepository = userRepository;
            this.bmr = new BasalMetabolicRate();
        }

        public async Task<CalculateBMRResponseModel> CalculateBMR(CalculateBMRRequestModel parameters,
                                                                  string email)
        {
            if (parameters.Gender.Equals(Gender.Male))
            {
                GetMaleBMR(parameters);
            }
            else
            {
               GetFamaleBMR(parameters);
            }

            CalculateBMRAfterGettingActivity(parameters.Activity);

            var user = await this.userRepository.All().FirstOrDefaultAsync(u => u.Email == email);
            parameters.UserId = user.Id;

            var bmr = new BasalMetabolicRate()
            {
                BMR = this.bmr.BMR,
                BMRWithActivity = this.bmr.BMRWithActivity,
                Age = parameters.Age,
                Gender = parameters.Gender,
                Height = parameters.Height,
                Weight = parameters.Weight,
                UserId = parameters.UserId,
                ActivityId = parameters.Activity
            };

            await this.bmrRepository.AddAsync(bmr);
            await this.bmrRepository.SaveChangesAsync();

            var responseModel = new CalculateBMRResponseModel();
            responseModel.Message = Messages.SUCCESSFULLY_CALCULATED_BMR;
            responseModel.IsSuccess = true;
            responseModel.BMR = this.bmr.BMR;
            responseModel.BMRWithActivity = this.bmr.BMRWithActivity;

            return responseModel;
        }

        public double CalculateBMRAfterGettingActivity(long activity)
        {
            double bmr = this.bmr.BMR;

            if (activity.Equals(1))
            {
                bmr = bmr * Constans.PersonConstants.LITTLE_NO_EXERCISE;
            }
            else if (activity.Equals(2))
            {
                bmr = bmr * Constans.PersonConstants.LIGHT_EXERCISE;
            }
            else if (activity.Equals(3))
            {
                bmr = bmr * Constans.PersonConstants.MODERATE_EXERCISE;
            }
            else if (activity.Equals(4))
            {
                bmr = bmr * Constans.PersonConstants.VERY_ACTIVE;
            }
            else if(activity.Equals(5))
            {
                bmr = bmr * Constans.PersonConstants.EXTRA_ACTIVE;
            }
            else
            {
                throw new Exception("There is a problem with view bag or method!");
            }

            this.bmr.BMRWithActivity = bmr;
            return bmr;
        }

        public double GetFamaleBMR(CalculateBMRRequestModel parameters)
        {
            double calculation = 655.1 + (9.563 * parameters.Weight) + (1.85 * parameters.Height) - (4.676 * parameters.Age);
            this.bmr.BMR = calculation;
            return calculation;
        }

        public double GetMaleBMR(CalculateBMRRequestModel parameters)
        {
            double calculation = 66.47 + (13.75 * parameters.Weight) + (5.003 * parameters.Height) - (6.775 * parameters.Age);
            this.bmr.BMR = calculation;
            return calculation;
        }
    }
}
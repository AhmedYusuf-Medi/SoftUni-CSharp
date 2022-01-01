namespace BMR.Service.Services.Data
{
    using BMR.Data;
    using BMR.Models.Constans;
    using BMR.Models.Service.Models.Response.Macro;
    using BMR.Service.Common;
    using BMR.Service.Contracts;

    using Microsoft.EntityFrameworkCore;

    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class MacroService : IMacroService
    {
        private readonly BMRDbContext db;

        public MacroService(BMRDbContext db)
        {
            this.db = db;
        }

        public async Task<GetMacrosResponseModel> GetMacros(string email)
        {
            var user = await this.db.Users.Select
                                                (
                                                   u => new
                                                   {
                                                       u.BMRS,
                                                       u.Email
                                                   }
                                                ).FirstOrDefaultAsync(u => u.Email == email);

            if (user == null)
            {
                throw new NullReferenceException(ExceptionMessages.USER_NOTFOUND);
            }

            var bmr = user.BMRS.OrderByDescending(bmr => bmr.Id).First();

            if (bmr == null)
            {
                throw new NullReferenceException(ExceptionMessages.PLEASE_CALCULATE_YOUR_CALORIES);
            }

            var responseModel = new GetMacrosResponseModel();

            //Calculate Macros
            var bmrWithActivity = bmr.BMRWithActivity;
            responseModel.Protein = (int)Math.Floor((bmrWithActivity * Constans.PersonConstants.PROTEIN_PERCENTAGE) / Constans.PersonConstants.CALORIE_PER_PROTEIN);
            responseModel.Carb = (int)Math.Floor((bmrWithActivity * Constans.PersonConstants.CARB_PERCENTAGE) / Constans.PersonConstants.CALORIE_PER_CARB);
            bmrWithActivity -= (responseModel.Carb + responseModel.Protein) * Math.Max(Constans.PersonConstants.CALORIE_PER_CARB, Constans.PersonConstants.CALORIE_PER_PROTEIN);
            responseModel.Fat = (int)(bmrWithActivity / Constans.PersonConstants.CALORIE_PER_FAT);

            responseModel.Message = Messages.SUCCESSFULLY_CALCULATED_MACROS;
            responseModel.IsSuccess = true;

            return responseModel;
        }
    }
}
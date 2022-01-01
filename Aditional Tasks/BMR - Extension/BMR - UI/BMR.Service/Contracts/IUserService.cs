namespace BMR.Service.Contracts
{
    using BMR.Models.Data.Models;
    using BMR.Models.Service.Models.Request;
    using BMR.Models.Service.Models.Response.User;
    using System.Threading.Tasks;

    public interface IUserService
    {
        public Task<CreateUserResponseModel> RegisterAsync(UserRequestModel user);

        public Task<LoginUserResponseModel> LoginAsync(UserRequestModel user);

        public Task<DeleteUserResponseModel> DeleteAsync(long Id);

        public Task<UpdateUserResponseModel> UpdateAsync(long id, User user);

        public Task<RestoreUserResponseModel> RestoreAsync (User user);
    }
}

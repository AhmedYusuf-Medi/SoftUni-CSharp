namespace BMR.Service.Services.Data
{
    using BMR.Data.Common;
    using BMR.Models.Data.Models;
    using BMR.Models.Service.Models.Request;
    using BMR.Models.Service.Models.Response.User;
    using BMR.Service.Common;
    using BMR.Service.Contracts;

    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Threading.Tasks;

    public class UserService : IUserService
    {
        private readonly IDeletableEntityRepository<User> userRepository;

        public UserService(IDeletableEntityRepository<User> userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<LoginUserResponseModel> LoginAsync(UserRequestModel user)
        {
            var userToLog = await this.userRepository.All().FirstOrDefaultAsync(u => u.Email == user.Email);

            if (userToLog == null)
            {
                throw new NullReferenceException(string.Format(ExceptionMessages.USER_NOT_FOUND, user.Email));
            }

            if (!user.Password.Equals(userToLog.Password))
            {
                throw new ArgumentException(ExceptionMessages.INVALID_PASSWORD);
            }

            var responseModel = new LoginUserResponseModel();
            responseModel.Message = Messages.SUCCESSFULLY_LOGIN;
            responseModel.IsSuccess = true;
            responseModel.UserId = userToLog.Id;

            return responseModel;
        }

        public async Task<CreateUserResponseModel> RegisterAsync(UserRequestModel user)
        {
            var userToReg = new User()
            {
                Email = user.Email,
                Password = user.Password
            };

            bool doesUserExist = await this.userRepository.All().AnyAsync(u => u.Email == user.Email);

            if (doesUserExist)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.USER_WITH_EMAIL_ALREADY_EXIST, user.Email));
            }

            await this.userRepository.AddAsync(userToReg);
            await this.userRepository.SaveChangesAsync();

            var responseModel = new CreateUserResponseModel();
            responseModel.Message = Messages.SUCCESSFULLY_REGISTERED;
            responseModel.IsSuccess = true;

            return responseModel;
        }

        public async Task<UpdateUserResponseModel> UpdateAsync(long id, User user)
        {
            var userToUpdate = await this.userRepository.All().FirstOrDefaultAsync(u => u.Id == id);

            if (userToUpdate == null)
            {
                throw new NullReferenceException(string.Format(ExceptionMessages.USER_NOTFOUND));
            }

            bool isModified = false;
            if (user.Password != null && user.Password != userToUpdate.Password)
            {
                userToUpdate.Password = user.Password;
                isModified = true;
            }

            if (user.Email != null && user.Email != userToUpdate.Email)
            {
                userToUpdate.Email = user.Email;
                isModified = true;
            }

            if (isModified)
            {
                userToUpdate.ModifiedOn = DateTime.UtcNow;

                this.userRepository.Update(user);
                await this.userRepository.SaveChangesAsync();

                var responseModel = new UpdateUserResponseModel();
                responseModel.Message = Messages.SUCCESSFULLY_EDITED;
                responseModel.IsSuccess = true;
                return responseModel;
            }

            throw new ArgumentException(ExceptionMessages.EMPTY_FIELD);
        }

        public async Task<DeleteUserResponseModel> DeleteAsync(long id)
        {
            var userToDelete = await this.userRepository.All().FirstOrDefaultAsync(x => x.Id == id);

            if (userToDelete == null)
            {
                throw new NullReferenceException(string.Format(ExceptionMessages.USER_NOTFOUND, id));
            }

            this.userRepository.Delete(userToDelete);
            await this.userRepository.SaveChangesAsync();

            var responseModel = new DeleteUserResponseModel();
            responseModel.Message = Messages.SUCCESSFULLY_DELETED;
            responseModel.IsSuccess = true;

            return responseModel;
        }

        public async Task<RestoreUserResponseModel> RestoreAsync(User user)
        {
            var userToRestore = await this.userRepository.AllWithDeleted().FirstOrDefaultAsync(u => u.Email == user.Email &&
                                                                                               u.Password == user.Password);
            if (userToRestore == null)
            {
                throw new NullReferenceException(string.Format(ExceptionMessages.USER_NOTFOUND));
            }

            this.userRepository.Undelete(userToRestore);
            await this.userRepository.SaveChangesAsync();

            var responseModel = new RestoreUserResponseModel();
            responseModel.Message = Messages.SUCCESSFULLY_RESTORED;
            responseModel.IsSuccess = true;

            return responseModel;
        }
    }
}
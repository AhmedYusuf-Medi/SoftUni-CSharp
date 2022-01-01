namespace BMR.Test.Services.User
{
    using BMR.Data.Common;
    using BMR.Models.Service.Models.Request;
    using BMR.Models.Service.Models.Response.User;
    using BMR.Service.Common;
    using BMR.Service.Services.Data;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MockQueryable.Moq;
    using Moq;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [TestClass]
    public class Login_Should
    {
        [TestMethod]
        public async Task Login_Should_Return_CorrectMessage()
        {
            var mockContext = new Mock<IDeletableEntityRepository<Models.Data.Models.User>>();

            var users = new List<Models.Data.Models.User>()
            {
                new Models.Data.Models.User
                {
                    Id = 1,
                    Email = "muthkabarona@gmail.com",
                    Password ="password"
                }
            };

            var mockUsersDbSet = users.AsQueryable().BuildMockDbSet();

            mockContext.Setup(db => db.All()).Returns(mockUsersDbSet.Object);

            var service = new UserService(mockContext.Object);

            var requestModel = new UserRequestModel()
            {
                Email = "muthkabarona@gmail.com",
                Password = "password"
            };

            var result = await service.LoginAsync(requestModel);

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(LoginUserResponseModel));
            Assert.IsTrue(result.IsSuccess);
            Assert.AreEqual(result.Message, Messages.SUCCESSFULLY_LOGIN);
        }

        [TestMethod]
        public async Task Login_Should_ThrowException_WhenUserDoesntExist()
        {
            var mockContext = new Mock<IDeletableEntityRepository<Models.Data.Models.User>>();

            var users = new List<Models.Data.Models.User>()
            {
                new Models.Data.Models.User
                {
                    Id = 1,
                    Email = "muthkabarona@gmail.com",
                    Password ="password"
                }
            };

            var mockUsersDbSet = users.AsQueryable().BuildMockDbSet();

            mockContext.Setup(db => db.All()).Returns(mockUsersDbSet.Object);

            var service = new UserService(mockContext.Object);

            var requestModel = new UserRequestModel()
            {
                Email = "notexisting@gmail.com",
                Password = "password"
            };

            await Assert.ThrowsExceptionAsync<NullReferenceException>(() => service.LoginAsync(requestModel)); 
            var exception = await Assert.ThrowsExceptionAsync<NullReferenceException>(() => service.LoginAsync(requestModel));
            Assert.AreEqual(exception.Message, string.Format(ExceptionMessages.USER_NOT_FOUND, requestModel.Email));
        }

        [TestMethod]
        public async Task Login_Should_ThrowException_WhenPasswordIsWrong()
        {
            var mockContext = new Mock<IDeletableEntityRepository<Models.Data.Models.User>>();

            var users = new List<Models.Data.Models.User>()
            {
                new Models.Data.Models.User
                {
                    Id = 1,
                    Email = "muthkabarona@gmail.com",
                    Password ="password"
                }
            };

            var mockUsersDbSet = users.AsQueryable().BuildMockDbSet();

            mockContext.Setup(db => db.All()).Returns(mockUsersDbSet.Object);

            var service = new UserService(mockContext.Object);

            var requestModel = new UserRequestModel()
            {
                Email = "muthkabarona@gmail.com",
                Password = "wrongpassword"
            };

            await Assert.ThrowsExceptionAsync<ArgumentException>(() => service.LoginAsync(requestModel));
            var exception = await Assert.ThrowsExceptionAsync<ArgumentException>(() => service.LoginAsync(requestModel));
            Assert.AreEqual(exception.Message, ExceptionMessages.INVALID_PASSWORD);
        }
    }
}
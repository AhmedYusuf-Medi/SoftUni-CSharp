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
    public class Register_Should
    {
        [TestMethod]
        public async Task Register_Should_Return_CorrectMessage()
        {
            var mockContext = new Mock<IDeletableEntityRepository<Models.Data.Models.User>>();

            var users = new List<Models.Data.Models.User>()
            {
            };

            var mockUsersDbSet = users.AsQueryable().BuildMockDbSet();

            mockContext.Setup(db => db.All()).Returns(mockUsersDbSet.Object);

            var service = new UserService(mockContext.Object);

            var requestModel = new UserRequestModel()
            {
                Email = "muthkabarona@gmail.com",
                Password = "password"
            };

            var result = await service.RegisterAsync(requestModel);

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(CreateUserResponseModel));
            Assert.IsTrue(result.IsSuccess);
            Assert.AreEqual(result.Message, Messages.SUCCESSFULLY_REGISTERED);
        }

        [TestMethod]
        public async Task Register_Should_ThrowException_When_UserAlreadyExist()
        {
            var mockContext = new Mock<IDeletableEntityRepository<Models.Data.Models.User>>();

            var users = new List<Models.Data.Models.User>()
            {
                new Models.Data.Models.User
                {
                    Id = 1,
                    Email = "muthkabarona@gmail.com",
                    Password = "password"
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

            await Assert.ThrowsExceptionAsync<ArgumentException>(() => service.RegisterAsync(requestModel));
            var exception = await Assert.ThrowsExceptionAsync<ArgumentException>(() => service.RegisterAsync(requestModel));
            Assert.AreEqual(exception.Message, string.Format(ExceptionMessages.USER_WITH_EMAIL_ALREADY_EXIST, requestModel.Email));
        }
    }
}
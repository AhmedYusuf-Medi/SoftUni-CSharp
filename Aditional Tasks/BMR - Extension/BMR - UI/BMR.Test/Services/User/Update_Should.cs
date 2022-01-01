namespace BMR.Test.Services.User
{
    using BMR.Data.Common;
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
    public class Update_Should
    {
        [TestMethod]
        public async Task Update_Should_Return_CorrectMessage()
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

            var requestModel = new Models.Data.Models.User()
            {
                Email = "newemail@gmail.com",
                Password = "newpassword"
            };

            var result = await service.UpdateAsync(1, requestModel);

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(UpdateUserResponseModel));
            Assert.IsTrue(result.IsSuccess);
            Assert.AreEqual(result.Message, Messages.SUCCESSFULLY_EDITED);
        }

        [TestMethod]
        public async Task Update_Should_ThrowException_WhenUserDoesnt_Exist()
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

            var requestModel = new Models.Data.Models.User()
            {
                Email = "newemail@gmail.com",
                Password = "newpassword"
            };

            await Assert.ThrowsExceptionAsync<NullReferenceException>(() => service.UpdateAsync(long.MaxValue, requestModel));
            var exception = await Assert.ThrowsExceptionAsync<NullReferenceException>(() => service.UpdateAsync(long.MaxValue, requestModel));
            Assert.AreEqual(exception.Message, string.Format(ExceptionMessages.USER_NOTFOUND));
        }

        [TestMethod]
        public async Task Update_Should_ThrowException_WhenFieldsAre_Empty()
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

            var requestModel = new Models.Data.Models.User(){};

            await Assert.ThrowsExceptionAsync<ArgumentException>(() => service.UpdateAsync(1, requestModel));
            var exception = await Assert.ThrowsExceptionAsync<ArgumentException>(() => service.UpdateAsync(1, requestModel));
            Assert.AreEqual(exception.Message, string.Format(ExceptionMessages.EMPTY_FIELD));
        }
    }
}
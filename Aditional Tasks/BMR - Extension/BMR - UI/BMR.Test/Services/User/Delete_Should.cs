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
    public class Delete_Should
    {
        [TestMethod]
        public async Task Delete_Should_Return_CorrectMessage()
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

            var result = await service.DeleteAsync(1);

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(DeleteUserResponseModel));
            Assert.IsTrue(result.IsSuccess);
            Assert.AreEqual(result.Message, Messages.SUCCESSFULLY_DELETED);
        }

        [TestMethod]
        public async Task Delete_Should_ThrowException_WhenGivenIdDoesntExist()
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

            await Assert.ThrowsExceptionAsync<NullReferenceException>(() => service.DeleteAsync(long.MaxValue));
            var exception = await Assert.ThrowsExceptionAsync<NullReferenceException>(() => service.DeleteAsync(long.MaxValue));
            Assert.AreEqual(exception.Message, string.Format(ExceptionMessages.USER_NOTFOUND, long.MaxValue));
        }
    }
}

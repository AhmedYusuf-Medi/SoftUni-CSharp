using BMR.Data;
using BMR.Models.Data.Models;
using BMR.Models.Enums;
using BMR.Models.Service.Models.Response.Macro;
using BMR.Service.Common;
using BMR.Service.Services.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockQueryable.Moq;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMR.Test.Services.Macro
{
    [TestClass]
    public class GetMacros_Should
    {
        [TestMethod]
        public async Task GetMacros_Should_Return_CorrectData()
        {
            var mockContext = new Mock<BMRDbContext>();

            var activities = new List<Activity>
            {
               new Activity
               {
                  Id = 1,
                  Name = "Little No Exercise"
               }
            };

            var users = new List<Models.Data.Models.User>()
            {
                new Models.Data.Models.User
                {
                    Id = 1,
                    Email = "muthkabarona@gmail.com",
                    Password = "password",
                    BMRS = new HashSet<BasalMetabolicRate>
                    {
                        new BasalMetabolicRate
                        {
                          BMR = 1.830,
                          BMRWithActivity = 2.516,
                          Gender =Gender.Male,
                          Age = 20,
                          Height = 180,
                          Weight = 80,
                          UserId = 1,
                          ActivityId = 1,
                          Activity = activities[0]
                        }
                    }
                } 
            };

            var mockUsersDbSet = users.AsQueryable().BuildMockDbSet();
            var mockActivitiesDbSet = activities.AsQueryable().BuildMockDbSet();


            mockContext.Setup(db => db.Activities).Returns(mockActivitiesDbSet.Object);
            mockContext.Setup(db => db.Users).Returns(mockUsersDbSet.Object);

            var service = new MacroService(mockContext.Object);

            var result = await service.GetMacros("muthkabarona@gmail.com");

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(GetMacrosResponseModel));
            Assert.IsTrue(result.IsSuccess);
            Assert.AreEqual(result.Message, Messages.SUCCESSFULLY_CALCULATED_MACROS);
        }
    }
}
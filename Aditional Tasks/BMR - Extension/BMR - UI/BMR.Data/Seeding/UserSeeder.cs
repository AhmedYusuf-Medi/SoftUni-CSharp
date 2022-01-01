namespace BMR.Data.Seeding
{
    using BMR.Models.Data.Models;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class UserSeeder : ISeeder
    {
        public async Task SeedAsync(BMRDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Users.Any())
            {
                return;
            }

            var users = new List<(string Email, string Password)>
            {
                ("stevenvselenski@gmail.com", "password"),
                ("muthkabarona@gmail.com", "password")
            };

            foreach (var user in users)
            {
                await dbContext.Users.AddAsync(new User
                {
                    Email = user.Email,
                    Password = user.Password
                });
            }
        }
    }
}

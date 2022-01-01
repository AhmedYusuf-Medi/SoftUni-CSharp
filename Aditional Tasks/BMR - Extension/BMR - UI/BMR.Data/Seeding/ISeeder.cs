namespace BMR.Data.Seeding
{
    using System;
    using System.Threading.Tasks;

    public interface ISeeder
    {
        Task SeedAsync(BMRDbContext dbContext, IServiceProvider serviceProvider);
    }
}

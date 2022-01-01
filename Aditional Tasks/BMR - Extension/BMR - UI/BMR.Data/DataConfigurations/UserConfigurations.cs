namespace BMR.Data.DataConfigurations
{
    using BMR.Models.Data.Models;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasIndex(u => new { u.Email })
                   .IsUnique();
        }
    }
}

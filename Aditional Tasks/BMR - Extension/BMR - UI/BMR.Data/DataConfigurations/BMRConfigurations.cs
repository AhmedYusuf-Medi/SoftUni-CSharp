namespace BMR.Data.DataConfigurations
{
    using BMR.Models.Data.Models;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class BMRConfigurations : IEntityTypeConfiguration<BasalMetabolicRate>
    {
        public void Configure(EntityTypeBuilder<BasalMetabolicRate> builder)
        {
            builder.HasOne(bmr => bmr.User)
                   .WithMany(u => u.BMRS)
                   .HasForeignKey(bmr => bmr.UserId)
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_BMRS_Users");

            builder.HasOne(bmr => bmr.Activity)
                   .WithMany(a => a.BMRS)
                   .HasForeignKey(bmr => bmr.ActivityId)
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_BMRS_Activities");
        }
    }
}

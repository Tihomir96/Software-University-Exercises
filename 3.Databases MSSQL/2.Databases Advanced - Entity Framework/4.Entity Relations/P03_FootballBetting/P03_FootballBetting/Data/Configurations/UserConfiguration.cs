using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P03_FootballBetting.Data.Models;

namespace P03_FootballBetting.Data.Configurations
{
    public class UserConfiguration:IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.UserId);
            builder.Property(e => e.Name)
                .HasMaxLength(100);

            builder.Property(e => e.Username)
                .IsRequired();
            builder.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(e => e.Email)
                .HasMaxLength(60);
        }
    }
}

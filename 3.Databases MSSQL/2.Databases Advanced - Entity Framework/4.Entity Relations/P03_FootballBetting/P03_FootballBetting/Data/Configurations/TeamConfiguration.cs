using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P03_FootballBetting.Data.Models;

namespace P03_FootballBetting.Data.Configurations
{
    public class TeamConfiguration:IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(e => e.TeamId);

            builder.Property(e => e.Name)
                   .IsRequired()
                   .HasMaxLength(80);

            builder.Property(e => e.Initials)
                   .IsRequired()
                   .HasColumnType("NCHAR(3)");

            builder.Property(e => e.LogoUrl)
                   .IsUnicode(false);

            builder.HasOne(e => e.PrimaryKitColor)
                .WithMany(e => e.PrimaryKitTeams)
                .HasForeignKey(e => e.PrimaryKitColorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.SecondaryKitColor)
                .WithMany(e => e.SecondaryKitTeams)
                .HasForeignKey(e => e.SecondaryKitColorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Town)
                .WithMany(e => e.Teams)
                .HasForeignKey(e => e.TownId);
        }
    }
}

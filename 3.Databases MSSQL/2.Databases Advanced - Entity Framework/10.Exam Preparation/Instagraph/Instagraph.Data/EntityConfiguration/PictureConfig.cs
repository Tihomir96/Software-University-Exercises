using Instagraph.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Instagraph.Data.EntityConfiguration
{
    public class PictureConfig:IEntityTypeConfiguration<Picture>
        
    {
        public void Configure(EntityTypeBuilder<Picture> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Size).HasColumnType("DECIMAL");

            builder.HasMany(x => x.Users)
                .WithOne(x => x.ProfilePicture)
                .HasForeignKey(x => x.ProfilePictureId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasMany(x => x.Posts)
                .WithOne(x => x.Picture)
                .HasForeignKey(x => x.PictureId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

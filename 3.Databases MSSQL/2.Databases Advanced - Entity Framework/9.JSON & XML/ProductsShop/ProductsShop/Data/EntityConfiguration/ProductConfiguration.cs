using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductsShop.Data.Models;

namespace ProductsShop.Data.EntityConfiguration
{
    public class ProductConfiguration:IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Name)
                .IsRequired();
            builder.Property(x => x.Price)
                .IsRequired();
            builder.Property(x => x.BuyerId)
                .IsRequired(false);
            builder.Property(x => x.SellerId)
                .IsRequired();

         
        }
    }
}

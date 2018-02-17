using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_BillsPaymentSystem.Data.Models;

namespace P01_BillsPaymentSystem.Data.EntityConfig
{
    public class CreditCardConfiguration:IEntityTypeConfiguration<CreditCard>
    {
        public void Configure(EntityTypeBuilder<CreditCard> builder)
        {
            builder.HasKey(e => e.CreditCardId);
            
            builder.Ignore(e => e.LimitLeft);
            builder.Property(e => e.ExpirationDate)
                .HasColumnType("DATETIME2");

            builder.Ignore(e => e.PaymentMethodId);
        }
    }
}

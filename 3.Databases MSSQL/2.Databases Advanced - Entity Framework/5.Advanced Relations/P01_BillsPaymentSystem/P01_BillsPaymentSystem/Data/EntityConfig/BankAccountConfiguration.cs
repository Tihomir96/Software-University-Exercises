using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_BillsPaymentSystem.Data.Models;

namespace P01_BillsPaymentSystem.Data.EntityConfig
{
    public class BankAccountConfiguration:IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder.HasKey(e => e.BankAccountId);
            builder.Property(e => e.BankName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode();
            builder.Property(e => e.SwiftCode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
            builder.Ignore(e => e.PaymentMethodId);
        }
    }
}

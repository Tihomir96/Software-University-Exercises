using FastFood.Models;
using Microsoft.EntityFrameworkCore;

namespace FastFood.Data
{
	public class FastFoodDbContext : DbContext
	{
	    public DbSet<Employee> Employees { get; set; }
	    public DbSet<Category> Categories { get; set; }
	    public DbSet<Item> Items { get; set; }
	    public DbSet<Order> Orders { get; set; }
	    public DbSet<OrderItem> OrderItems { get; set; }
	    public DbSet<Position> Positions { get; set; }
		public FastFoodDbContext()
		{
		}

		public FastFoodDbContext(DbContextOptions options)
			: base(options)
		{
		}

		protected override void OnConfiguring(DbContextOptionsBuilder builder)
		{
			if (!builder.IsConfigured)
			{
				builder.UseSqlServer(Configuration.ConnectionString);
			}
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{

		    builder.Entity<Position>(x => x.HasKey(y => y.Id));
		    builder.Entity<Item>(x => x.HasKey(y => y.Id));
            builder.Entity<Position>(x => x.HasIndex(i=>i.Name).IsUnique());
		    builder.Entity<Category>(x => x.HasIndex(i=>i.Name).IsUnique());
		    builder.Entity<Item>(x => x.HasIndex(i => i.Name).IsUnique());
		    builder.Entity<Order>(x => x.Ignore(i => i.TotalPrice));
		    builder.Entity<OrderItem>(x => x.HasKey(k => new {k.ItemId, k.OrderId}));
		    builder.Entity<OrderItem>(x => x.HasOne(y => y.Order)
		        .WithMany(ot => ot.OrderItems)
		        .HasForeignKey(f => f.OrderId)
                .OnDelete(DeleteBehavior.Restrict));
		    builder.Entity<OrderItem>(x => x.HasOne(y => y.Item).WithMany(t => t.OrderItems).HasForeignKey(fk => fk.ItemId).OnDelete(DeleteBehavior.Restrict));
		    //builder.Entity<Employee>(
		    //    x => x.HasMany(y => y.Orders).WithOne(o => o.Employee).HasForeignKey(fk => fk.EmployeeId).OnDelete(DeleteBehavior.Restrict));
		    //builder.Entity<Category>(x => x.HasMany(i => i.Items).WithOne(c => c.Category).HasForeignKey(fk => fk.CategoryId)
		    //    .OnDelete(DeleteBehavior.Restrict));
      //      builder.Entity<Employee>(y=>y.HasOne(x=>x.Position).WithMany(x=>x.Employees).HasForeignKey(i=>i.PositionId)
		    //    .OnDelete(DeleteBehavior.Restrict));

		}
	}
}
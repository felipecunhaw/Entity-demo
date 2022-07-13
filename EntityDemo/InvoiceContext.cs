using EntityDemo.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityDemo
{
    public class InvoiceContext : DbContext
    {
        public InvoiceContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<InvoiceItems> InvoiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Invoice>()
                .HasOne(x => x.Customer)
                .WithOne()
                .HasForeignKey<Invoice>(x => x.CustomerId);

            modelBuilder
                .Entity<InvoiceItems>()
                .HasOne(b => b.Invoice)
                .WithMany(a => a.Items);
        }
    }
}

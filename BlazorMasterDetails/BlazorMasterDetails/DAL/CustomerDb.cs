using BlazorMasterDetails.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorMasterDetails.DAL
{
	public class CustomerDb : DbContext
	{
		public CustomerDb(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Customer> Customers { get; set; } = default!;
		public DbSet<Invoice> Invoices { get; set; } = default!;


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CustomerInvDb;Trusted_Connection=True");


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Customer>().HasData(new Customer[]
			{
				new Customer
				{
					CustomerID = 1,
					Name = "Sayem",
					IsNew = true
				},
				new Customer
				{
					CustomerID = 2,
					Name = "Jamir",
					IsNew = true
				},
				new Customer
				{
					CustomerID = 3,
					Name = "Enam",
					IsNew = true
				}
			});


			modelBuilder.Entity<Invoice>().HasData(new Invoice[]
			{
				new Invoice
				{
					InvoiceID = 1,
					InvoiceNumber = "AZ02u",
					InvoiceDate = Convert.ToDateTime("2024-03-10"),
					StandardCost = 1341,
					CustomerId = 1
				},
				new Invoice
				{
					InvoiceID = 2,
					InvoiceNumber = "LZ02u",
					InvoiceDate = Convert.ToDateTime("2024-03-11"),
					StandardCost = 1451,
					CustomerId = 1
				},
				new Invoice
				{
					InvoiceID = 3,
					InvoiceNumber = "EZ02u",
					InvoiceDate = Convert.ToDateTime("2024-03-12"),
					StandardCost = 521,
					CustomerId = 2
				},
				new Invoice
				{
					InvoiceID = 4,
					InvoiceNumber = "MZ02u",
					InvoiceDate = Convert.ToDateTime("2024-03-12"),
					StandardCost = 2652,
					CustomerId = 2
				},
				new Invoice
				{
					InvoiceID = 5,
					InvoiceNumber = "BZ02u",
					InvoiceDate = Convert.ToDateTime("2024-03-13"),
					StandardCost = 2526,
					CustomerId = 3
				}
				});
		}
	}
}
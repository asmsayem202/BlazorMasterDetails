using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BlazorMasterDetails.Models
{
	public class Customer
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

		public int CustomerID { get; set; }

		[Required, NotNull]
		public string Name { get; set; }

        public bool IsNew { get; set; }

        public ICollection<Invoice> Invoices { get; set; } = [];
	}
}

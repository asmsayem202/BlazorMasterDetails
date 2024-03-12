using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMasterDetails.Models
{
	public class Invoice
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int InvoiceID { get; set; }

		[Required]
		public string InvoiceNumber { get; set; }
		
		[Required]
		public DateTime InvoiceDate { get; set; }

		[Required]
		public int StandardCost { get; set; }


		[ForeignKey(nameof(Customer.CustomerID))]
		public int CustomerId { get; set; }

		public Customer? Customer { get; set; }
	}
}

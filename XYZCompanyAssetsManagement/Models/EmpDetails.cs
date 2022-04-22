using System;
using System.ComponentModel.DataAnnotations;

namespace XYZCompanyAssetsManagement.Models
{
	public class EmpDetails
	{
		[Key]
		public int? Id { get; set; } 
		public string? EmpName { get; set; }
		public string? EmailId { get; set; }
		public int PhoneNo { get; set; }
		public string? Address { get; set; }

	}
}


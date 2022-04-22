using System;
using System.ComponentModel.DataAnnotations;

namespace XYZCompanyAssetsManagement.Models
{
	public class AssetsDetails
	{
		[Key]
		public int Id { get; set; }
		public string? Type { get; set; }
		public string? Name { get; set; }
		public int IdentifyNo { get; set; }
	}
}


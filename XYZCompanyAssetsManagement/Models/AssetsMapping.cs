using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XYZCompanyAssetsManagement.Models
{
	public class AssetsMapping 
	{
		[Key]
		public int Id { get; set; }
		public DateTime DateOfIssue { get; set; }
		public DateTime? DateOfReturn { get; set; }

		[ForeignKey("EmpDetails")]
		public int EmpId{ get; set; }

		[ForeignKey("AssetsDetails")]
		public int AssetsId { get; set; }
	}
}


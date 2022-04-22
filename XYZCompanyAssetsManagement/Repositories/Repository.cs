using System;
using XYZCompanyAssetsManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace XYZCompanyAssetsManagement.Repositories
{
	public class Repository : DbContext
	{
        public Repository(DbContextOptions<Repository> options) : base(options)
        {
		}

		public DbSet<EmpDetails> EmpDetails { get; set; }
		public DbSet<AssetsDetails>AssetsDetails { get; set; }
		public DbSet<AssetsMapping> AssetsMapping { get; set; }

	}
}


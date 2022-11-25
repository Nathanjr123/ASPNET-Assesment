using System;
using Microsoft.EntityFrameworkCore;
using ASPNET.Models;
namespace ASPNET.Data
{
	public class ApplicationDbContext: DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}
		public DbSet<user> user
		{
			get;
			set;
		}
        public DbSet<vehicle> vehicle
        {
            get;
            set;
        }
        public DbSet<account> account
        {
            get;
            set;
        }
    }
}


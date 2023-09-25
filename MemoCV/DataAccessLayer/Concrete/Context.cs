using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-OVKQU94;database=MemoCVDB;integrated security=true;");
		}
		public DbSet<About> Abouts { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<Message> Messages { get; set; }
        public DbSet<Service> Services { get; set; }	
		public DbSet<Skill> Skills { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }
		public DbSet<Admin> Admins { get; set; }

	}
}

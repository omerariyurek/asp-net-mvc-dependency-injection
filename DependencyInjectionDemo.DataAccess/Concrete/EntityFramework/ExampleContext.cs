using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionDemo.Entities.Concrete;

namespace DependencyInjectionDemo.DataAccess.Concrete.EntityFramework
{
	public class ExampleContext:DbContext
	{
		public ExampleContext():base("databaseConnection")
		{
			Database.SetInitializer(new DatabaseInitializer());
		}

		public DbSet<Product> Products { get; set; }
	}
}

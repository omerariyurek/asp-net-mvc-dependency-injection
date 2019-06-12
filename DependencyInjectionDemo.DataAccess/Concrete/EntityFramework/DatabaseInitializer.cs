using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionDemo.Entities.Concrete;

namespace DependencyInjectionDemo.DataAccess.Concrete.EntityFramework
{
	public class DatabaseInitializer:CreateDatabaseIfNotExists<ExampleContext>
	{
		protected override void Seed(ExampleContext context)
		{
			List<Product> Products = new List<Product>()
			{
				new Product() {ProductName = "Chai", UnitPrice = 18, UnitsInStock = 60},
				new Product() {ProductName = "Chang", UnitPrice = 19, UnitsInStock = 140},
				new Product() {ProductName = "Aniseed Syrup", UnitPrice = 10, UnitsInStock = 55},
				new Product() {ProductName = "Chef Anton's Cajun Seasoning", UnitPrice = 22, UnitsInStock = 25},
				new Product() {ProductName = "Chef Anton's Gumbo Mix", UnitPrice = 25, UnitsInStock = 15},
				new Product() {ProductName = "Uncle Bob's Organic Dried Pears", UnitPrice = 30, UnitsInStock = 35},
				new Product() {ProductName = "Ikura", UnitPrice = 35, UnitsInStock = 20}
			};
			Products.ForEach(product => context.Products.Add(product));
			context.SaveChanges();
			base.Seed(context);
		}
	}
}

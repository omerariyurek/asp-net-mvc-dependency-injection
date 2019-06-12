using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionDemo.DataAccess.Abstract;
using DependencyInjectionDemo.Entities.Concrete;

namespace DependencyInjectionDemo.DataAccess.Concrete.EntityFramework
{
	public class EfProductDal:IProductDal
	{
		public List<Product> Products()
		{
			using (ExampleContext exampleContext = new ExampleContext())
			{
				return exampleContext.Products.ToList();
			}
		}
	}
}

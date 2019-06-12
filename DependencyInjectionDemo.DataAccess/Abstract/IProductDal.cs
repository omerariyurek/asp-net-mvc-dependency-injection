using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionDemo.Entities.Concrete;

namespace DependencyInjectionDemo.DataAccess.Abstract
{
	public interface IProductDal
	{
		List<Product> Products();
	}
}

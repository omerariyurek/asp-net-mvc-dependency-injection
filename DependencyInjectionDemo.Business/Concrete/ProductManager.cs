using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionDemo.Business.Abstract;
using DependencyInjectionDemo.DataAccess.Abstract;
using DependencyInjectionDemo.Entities.Concrete;

namespace DependencyInjectionDemo.Business.Concrete
{
	public class ProductManager : IProductService
	{
		private IProductDal _productDal;

		public ProductManager(IProductDal productDal)
		{
			_productDal = productDal;
		}

		public List<Product> Products()
		{
			return _productDal.Products();
		}
	}
}

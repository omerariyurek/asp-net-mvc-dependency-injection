using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionDemo.Business.Abstract;
using DependencyInjectionDemo.Business.Concrete;
using DependencyInjectionDemo.DataAccess.Abstract;
using DependencyInjectionDemo.DataAccess.Concrete.AdoNet;
using DependencyInjectionDemo.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace DependencyInjectionDemo.Business.DependencyResolver
{
	public class BusinessModule : NinjectModule
	{
		public override void Load()
		{
			Bind<IProductService>().To<ProductManager>().InSingletonScope();
			Bind<IProductDal>().To<AdoNetProductDal>().InSingletonScope();
		}
	}
}

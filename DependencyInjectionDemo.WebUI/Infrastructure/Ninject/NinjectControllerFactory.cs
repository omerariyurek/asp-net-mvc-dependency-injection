using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using Ninject.Modules;

namespace DependencyInjectionDemo.WebUI.Infrastructure.Ninject
{
	public class NinjectControllerFactory : DefaultControllerFactory
	{
		private IKernel _kernel;

		public NinjectControllerFactory(INinjectModule ninjectModule)
		{
			_kernel = new StandardKernel(ninjectModule);
		}

		protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
		{
			return controllerType == null ? null : (IController)_kernel.Get(controllerType);
		}
	}
}
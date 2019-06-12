using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DependencyInjectionDemo.Business.Abstract;

namespace DependencyInjectionDemo.WebUI.Controllers
{
    public class ProductController : Controller
    {
	    private IProductService _productService;
	    public ProductController(IProductService productService)
	    {
		    _productService = productService;
	    }

	    public ActionResult Index()
	    {
		    var model = _productService.Products();
            return View(model);
        }
    }
}
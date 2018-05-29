using AjaxPageList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;

namespace AjaxPageList.Controllers
{
    public class HomeController : Controller
    {
        public List<ProductViewModel> list = new List<ProductViewModel>();
        public List<Catalog> catalogList = new List<Catalog>();
        public HomeController()
        {
            initData();
        }
        public void initData()
        {
            var groupNumbers = 3;
            var catalogCount = 3;
            for (var i = 0; i <= catalogCount; i++)
            {
                var cata = new Catalog
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "【类别-" + i + "】",
                };
                catalogList.Add(cata);
                for (var j = 0; j <= groupNumbers; j++)
                {
                    var product = new ProductViewModel
                    {
                        CatalogId = cata.Id,
                        Name = cata.Name + "_产品-" + j,
                        Node = cata.Name
                    };
                    list.Add(product);
                }
            }
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ProductList(int page = 1)
        {
            var pageSize = 5;
           // var data = list.Skip((page-1)*pageSize).Take(pageSize).ToList();

            var pagelist =  new PagedList.PagedList<ProductViewModel>(list, page, pageSize);
            PagedListModel vm = new PagedListModel
            {
                Products = pagelist,
            };
            if (Request.IsAjaxRequest())
            {
                return PartialView("ProductList", vm);
            }
            else
            {
                return PartialView(vm);
            }

        }
    }
}
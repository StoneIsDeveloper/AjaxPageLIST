using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxPageList.Models
{
    public class PagedListModel
    {

        public string CatalogId { get; set; }
        public string Name { get; set; }
        public string Node { get; set; }
        public PagedList.IPagedList<ProductViewModel> Products { get; set; }
    }

    public class ProductViewModel
    {
        public string CatalogId { get; set; }
        public string Name { get; set; }
        public string Node { get; set; }
    }

    public class Catalog
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GroupProjectWeb.Models;

namespace GroupProjectWeb.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        private GroupProjectDataEntities db = new GroupProjectDataEntities();
        public ActionResult Search(string cat, string subcat)
        {
            return View(db.tblProducts.Where(x => x.Category_Name.Contains(cat) && x.SubCategory_Name.Contains(subcat)).ToList());
        }

        
    }
}
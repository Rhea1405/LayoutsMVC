using LayoutsMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutsMVC.Controllers
{
    public class CheckboxController : Controller
    {
        // GET: Checkbox
        List<EMPDATA> l = null;
        public ActionResult Viewdetails()
        {
            l = LayoutOperations.Getall();

            ViewBag.emplist = l;
            return View();
        }
        public ActionResult chckboxextract()
        {
          var e = Request.Form.Get("chckbox");
            l = LayoutOperations.Getall();
            List<EMPDATA> newlist = new List<EMPDATA>();
            foreach(var item in l)
            {
                if (e.Contains(item.EMPNO.ToString()))
                {
                    newlist.Add(item);
                }

            }
          
            return View(newlist);


        }
    }
}
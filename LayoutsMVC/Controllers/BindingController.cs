using LayoutsMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutsMVC.Controllers
{
    public class BindingController : Controller
    {
        // GET: Binding
        [ActionName("Example")]//for the end user it will show while running as "Example" 
        public ActionResult Sample()
        {
            return View("Sample");//when using actionname, we have to specify methodname in view.
        }
        public ActionResult Index_bind()
        {
            return View();
        }
        public ActionResult Update_Bind(int id)//always use id because it represents the primary key in that table
        {


            return View("Index_bind",LayoutOperations.emp_edit(id));
        }
        //[HttpPost]
        //public ActionResult Update_Bind(EMPDATA e)//receiving object using bind-called as complex binding
        //{

        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Update_Bind(FormCollection f)
        //{
        //    int eno = int.Parse(f["EMPNO"]);
        //    string ename = f["ENAME"];
        //    return View();


        //}
        [HttpPost]
        public ActionResult Update_Bind([Bind(Include="EMPNO,ENAME")]EMPDATA e)
        {

            return View();
        }
       
     


    }
}
using LayoutsMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutsMVC.Controllers
{
    public class EMPController : Controller
    {
        // GET: EMP
        public ActionResult Index()
        {
            List<EMPDATA> l = LayoutOperations.Getall();
            return View(l);
        }
        public ActionResult create()
        {
           
          
            return View();
        }
       
        public ActionResult createrecord(EMPDATA e)
        {
            ViewBag.msg = LayoutOperations.InsertEMPDATA(e);
            return View("create");
        }
       


        public ActionResult edit(int id)
        {
            EMPDATA emp = LayoutOperations.emp_edit(id);
            return View(emp);

            
        }
        public ActionResult extract_edit(EMPDATA e)
        {
            int empno = int.Parse(Request.Form["EMPNO"]);
            string s = LayoutOperations.editbtn(empno, e);
            ViewBag.msg = s;
            return View("edit");



        }
        public ActionResult delete_emp(int id)
        {
          
            LayoutOperations.empno_del(id);
            return RedirectToAction("Index");
        }

    }
}
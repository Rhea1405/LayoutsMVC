using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LayoutsMVC.Models
{
    public class LayoutOperations
    {


        static DemoEntities d = new DemoEntities();
      //  static DemoEntities1 d1 = new DemoEntities1();

        public static bool Checklogin(string username,string password)
        {
            var le = (from l in d.Logintables
                      where l.username == username && l.password == password
                      select l).FirstOrDefault();
            if (le != null)
            {
                return true;
            }
            else
                return false;

        }
        public static List<EMPDATA> Getall()
        {
            var E = from l in d.EMPDATAs
                    select l;
            return E.ToList();
        }
        public static string InsertEMPDATA(EMPDATA a)
        {
            try
            {
                d.EMPDATAs.Add(a);
                d.SaveChanges();
            }
            catch (DbUpdateException d)
            {
                SqlException ex = d.GetBaseException() as SqlException;
                if (ex.Message.Contains("EMP_PK"))
                {
                    return "same empno cant be added";
                }
                if (ex.Message.Contains("FK__EMPDATA__DEPTNO__236943A5"))
                {
                    return "no proper dept no";
                }

            }
            return "1 Row Inserted";
        }
        public static EMPDATA emp_edit(int empno)
        {
            var le = from l in d.EMPDATAs
                     where l.EMPNO == empno
                     select l;
            return le.FirstOrDefault();

        }
        public static string editbtn(int empno,EMPDATA e)
        {
            var le = from l in d.EMPDATAs
                     where l.EMPNO == empno
                     select l;
            foreach (var item in le)
            {
                item.JOB = e.JOB;
                item.MGR = e.MGR;
                item.SAL = e.SAL;
                item.COMM = e.COMM;
                item.DEPTNO = e.DEPTNO;


            }
            d.SaveChanges();
            return "updation done successfully";

        }
        public static void empno_del(int empno)
        {
            var le = (from l in d.EMPDATAs
                      where l.EMPNO == empno
                      select l).FirstOrDefault();
            d.EMPDATAs.Remove(le);
            d.SaveChanges();
            //return "successful deletion";



        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataRecovery.Models;

namespace DataRecovery.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            using (bcbzEntities db = new bcbzEntities())
            {
                string[] data = System.IO.File.ReadAllLines(@"d:\20130326UserIncome.txt");
                int id = 0;
                int incomeType = 0;
                UserIncome ui = null;
                string[] id_type = null;
                foreach (var item in data)
                {
                    id_type = item.Split('\t');
                    try
                    {
                        id = int.Parse(id_type[0]);
                        incomeType = int.Parse(id_type[2]);
                        ui = db.UserIncome.First(w => w.Id == id);
                        ui.IncomeType = incomeType;
                        db.SaveChanges();
                    }
                    catch
                    {
                        //System.IO.File.AppendText("id:" + id + " update faild.\n");
                    }
                }

            }

            return View();
        }

    }
}

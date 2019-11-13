using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCcomMenuInterativo.Models;

namespace MVCcomMenuInterativo.Controllers
{
    public class HomeController : Controller
    {
        ContextoDados bd = new ContextoDados();

        public ActionResult Menu()
        {
            try
            {
                var result = bd.ItensDeMenu.ToList();
                //var result = (from m in objEntity.Menu_Tree_Structure
                //              select new Dynamic_Menu.Models.Menu_List
                //              {
                //                  M_CODE = m.M_CODE,
                //                  M_PARENT_CODE = m.M_PARENT_CODE,
                //                  M_NAME = m.M_NAME,
                //                  CONTROLLER_NAME = m.Controller_Name,
                //                  ACTION_NAME = m.Action_Name,
                //              }).ToList();
                return View("Menu", result);
            }
            catch (Exception ex)
            {
                var error = ex.Message.ToString();
                return Content("Error");
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
    }
}
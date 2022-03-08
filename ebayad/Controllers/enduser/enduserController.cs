using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ebayad.Models;

namespace ebayad.Controllers
{
    public class enduserController : Controller
    {
        //
        // GET: /enduser/
        private ebayadEntities db = new ebayadEntities();

        int department_id;
        int user_id;
        string userName;
        string department_name;
        string System_date = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        string fullname;
        int user_type = 2;

        void session_control()
        {
            if (Session["userID"] == null & Session["userName"] == null & Session["deptId"] == null
                & Session["userTypeId"] == null || Convert.ToUInt32(Session["userTypeId"]) != user_type)
            {
                Response.Redirect("~/login");
            }
            else
            {
                department_id = Convert.ToInt32(Session["deptId"].ToString());
                user_id = Convert.ToInt32(Session["userID"].ToString());
                userName = Session["userName"].ToString();
                department_name = Session["deptname"].ToString();
                fullname = Session["fullname"].ToString();
            }
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}

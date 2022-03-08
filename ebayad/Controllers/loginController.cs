using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ebayad.Models;

namespace ebayad.Controllers
{
    public class loginController : Controller
    {
        //
        // GET: /login/

        private ebayadEntities db = new ebayadEntities();

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(user_table model)
        {
            using (db)
            {
                var a = (from b in db.user_table
                         join c in db.user_type_table on b.user_type_id equals c.id
                         join d in db.user_status_table on b.user_status_id equals d.id
                         join e in db.department_table on b.department_id equals e.ID
                         where b.username == model.username && b.password == model.password
                         select new
                         {
                             user_id = b.id,
                             username = b.username,
                             dept_id = e.ID,
                             dept_name = e.DEPARTMENT_NAME,
                             user_type = c.user_type,
                             user_type_id = c.id,
                             respo = e.CODE,
                             fullname = b.fullname
                         }).FirstOrDefault();

                if (a == null)
                {
                    model.LoginErrorMessage = "Incorrect username or password";
                    return View("Index", model);
                }
                else
                {
                    //System admin Module
                    if (a.user_type_id.ToString() == "1")
                    {
                        Session["userID"] = a.user_id;
                        Session["userName"] = a.username;
                        Session["userTypeId"] = a.user_type_id;
                        return RedirectToAction("Index", "User");
                    }
                    //Admin Officer Module(End user)
                    else if (a.user_type_id.ToString() == "2")
                    {
                        //proceed 
                        Session["userID"] = a.user_id;
                        Session["userName"] = a.username;
                        Session["deptId"] = a.dept_id;
                        Session["respoCode"] = a.respo;
                        Session["userTypeId"] = a.user_type_id;
                        Session["user_type"] = a.user_type;
                        Session["fullname"] = a.fullname;
                        Session["deptname"] = a.dept_name;
                        return RedirectToAction("Index", "enduser");
                    }

                    // fund controller lofin session
                    else if (a.user_type_id.ToString() == "8")
                    {
                        Session["userID"] = a.user_id;
                        Session["userName"] = a.username;
                        Session["deptId"] = a.dept_id;
                        Session["respoCode"] = a.respo;
                        Session["userTypeId"] = a.user_type_id;
                        Session["user_type"] = a.user_type;
                        Session["fullname"] = a.fullname;
                        Session["deptname"] = a.dept_name;
                        return RedirectToAction("ppa", "fundcontrol");
                    }

                    // procesing unit sa budget // 7 = CBO - Receiving
                    else if (a.user_type_id.ToString() == "7")
                    {
                        //proceed 
                        Session["userID"] = a.user_id;
                        Session["userName"] = a.username;
                        Session["deptId"] = a.dept_id;
                        Session["respoCode"] = a.respo;
                        Session["userTypeId"] = a.user_type_id;
                        Session["user_type"] = a.user_type;
                        Session["fullname"] = a.fullname;
                        Session["deptname"] = a.dept_name;
                        return RedirectToAction("Incomming_docs", "CityBudget");
                    }
                    else if (a.user_type_id.ToString() == "9")
                    {

                        Session["userID"] = a.user_id;
                        Session["userName"] = a.username;
                        Session["deptId"] = a.dept_id;
                        Session["respoCode"] = a.respo;
                        Session["userTypeId"] = a.user_type_id;
                        Session["user_type"] = a.user_type;
                        Session["fullname"] = a.fullname;
                        Session["deptname"] = a.dept_name;
                        return RedirectToAction("receiving", "toroCafoa");
                    }
                    else if (a.user_type_id.ToString() == "10")
                    {
                        Session["userID"] = a.user_id;
                        Session["userName"] = a.username;
                        Session["deptId"] = a.dept_id;
                        Session["respoCode"] = a.respo;
                        Session["userTypeId"] = a.user_type_id;
                        Session["user_type"] = a.user_type;
                        Session["fullname"] = a.fullname;
                        Session["deptname"] = a.dept_name;

                        return RedirectToAction("yearEndReceiving", "raaoReceiving");
                    }


                    else if (a.user_type_id.ToString() == "5")
                    {
                        Session["userID"] = a.user_id;
                        Session["userName"] = a.username;
                        Session["deptId"] = a.dept_id;
                        Session["respoCode"] = a.respo;
                        Session["userTypeId"] = a.user_type_id;
                        Session["user_type"] = a.user_type;
                        Session["fullname"] = a.fullname;
                        Session["deptname"] = a.dept_name;
                        return RedirectToAction("Index", "auditor");
                    }

                    else if (a.user_type_id.ToString() == "11")
                    {
                        Session["userID"] = a.user_id;
                        Session["userName"] = a.username;
                        Session["deptId"] = a.dept_id;
                        Session["respoCode"] = a.respo;
                        Session["userTypeId"] = a.user_type_id;
                        Session["user_type"] = a.user_type;
                        Session["fullname"] = a.fullname;
                        Session["deptname"] = a.dept_name;

                        return RedirectToAction("incommingFurs", "furs");

                    }

                    else if (a.user_type_id.ToString() == "6")
                    {
                        Session["userID"] = a.user_id;
                        Session["userName"] = a.username;
                        Session["deptId"] = a.dept_id;
                        Session["respoCode"] = a.respo;
                        Session["userTypeId"] = a.user_type_id;
                        Session["user_type"] = a.user_type;
                        Session["fullname"] = a.fullname;
                        Session["deptname"] = a.dept_name;

                        return RedirectToAction("incomming", "iaReceiving");
                    }
                    else if (a.user_type_id.ToString() == "12")
                    {
                        Session["userID"] = a.user_id;
                        Session["userName"] = a.username;
                        Session["deptId"] = a.dept_id;
                        Session["respoCode"] = a.respo;
                        Session["userTypeId"] = a.user_type_id;
                        Session["user_type"] = a.user_type;
                        Session["fullname"] = a.fullname;
                        Session["deptname"] = a.dept_name;

                        return RedirectToAction("QueueDocs", "divisionChief");
                    }

                    else if (a.user_type_id.ToString() == "14")
                    {
                        Session["userID"] = a.user_id;
                        Session["userName"] = a.username;
                        Session["deptId"] = a.dept_id;
                        Session["respoCode"] = a.respo;
                        Session["userTypeId"] = a.user_type_id;
                        Session["user_type"] = a.user_type;
                        Session["fullname"] = a.fullname;
                        Session["deptname"] = a.dept_name;

                        return RedirectToAction("passReleasing", "releasing");
                    }

                    else if (a.user_type_id.ToString() == "13")
                    {
                        Session["userID"] = a.user_id;
                        Session["userName"] = a.username;
                        Session["deptId"] = a.dept_id;
                        Session["respoCode"] = a.respo;
                        Session["userTypeId"] = a.user_type_id;
                        Session["user_type"] = a.user_type;
                        Session["fullname"] = a.fullname;
                        Session["deptname"] = a.dept_name;

                        return RedirectToAction("toroClaimsreceiving", "toroClaims");
                    }

                    else if (a.user_type_id.ToString() == "15")
                    {
                        Session["userID"] = a.user_id;
                        Session["userName"] = a.username;
                        Session["deptId"] = a.dept_id;
                        Session["respoCode"] = a.respo;
                        Session["userTypeId"] = a.user_type_id;
                        Session["user_type"] = a.user_type;
                        Session["fullname"] = a.fullname;
                        Session["deptname"] = a.dept_name;

                        return RedirectToAction("financereceiving", "finance");
                    }

                    else if (a.user_type_id.ToString() == "16")
                    {
                        Session["userID"] = a.user_id;
                        Session["userName"] = a.username;
                        Session["deptId"] = a.dept_id;
                        Session["respoCode"] = a.respo;
                        Session["userTypeId"] = a.user_type_id;
                        Session["user_type"] = a.user_type;
                        Session["fullname"] = a.fullname;
                        Session["deptname"] = a.dept_name;

                        return RedirectToAction("cashReceiving", "cashVoucher");
                    }

                    else if (a.user_type_id.ToString() == "17")
                    {
                        Session["userID"] = a.user_id;
                        Session["userName"] = a.username;
                        Session["deptId"] = a.dept_id;
                        Session["respoCode"] = a.respo;
                        Session["userTypeId"] = a.user_type_id;
                        Session["user_type"] = a.user_type;
                        Session["fullname"] = a.fullname;
                        Session["deptname"] = a.dept_name;

                        return RedirectToAction("Create", "oldDocsEntry");
                    }
                    else if (a.user_type_id.ToString() == "3")
                    {
                        Session["userID"] = a.user_id;
                        Session["userName"] = a.username;
                        Session["deptId"] = a.dept_id;
                        Session["respoCode"] = a.respo;
                        Session["userTypeId"] = a.user_type_id;
                        Session["user_type"] = a.user_type;
                        Session["fullname"] = a.fullname;
                        Session["deptname"] = a.dept_name;

                        return RedirectToAction("Index", "DepartmentHead");
                    }
                    else if (a.user_type_id.ToString() == "19")
                    {
                        Session["userID"] = a.user_id;
                        Session["userName"] = a.username;
                        Session["deptId"] = a.dept_id;
                        Session["respoCode"] = a.respo;
                        Session["userTypeId"] = a.user_type_id;
                        Session["user_type"] = a.user_type;
                        Session["fullname"] = a.fullname;
                        Session["deptname"] = a.dept_name;

                        return RedirectToAction("Incomming", "gso");
                    }
                    else if (a.user_type_id.ToString() == "21")
                    {
                        Session["userID"] = a.user_id;
                        Session["userName"] = a.username;
                        Session["deptId"] = a.dept_id;
                        Session["respoCode"] = a.respo;
                        Session["userTypeId"] = a.user_type_id;
                        Session["user_type"] = a.user_type;
                        Session["fullname"] = a.fullname;
                        Session["deptname"] = a.dept_name;

                        return RedirectToAction("viewincomming", "rci");
                    }

                    else if (a.user_type_id.ToString() == "20")
                    {
                        Session["userID"] = a.user_id;
                        Session["userName"] = a.username;
                        Session["deptId"] = a.dept_id;
                        Session["respoCode"] = a.respo;
                        Session["userTypeId"] = a.user_type_id;
                        Session["user_type"] = a.user_type;
                        Session["fullname"] = a.fullname;
                        Session["deptname"] = a.dept_name;

                        return RedirectToAction("Incomming", "bacPo");
                    }

                    else if (a.user_type_id.ToString() == "22")
                    {
                        Session["userID"] = a.user_id;
                        Session["userName"] = a.username;
                        Session["deptId"] = a.dept_id;
                        Session["respoCode"] = a.respo;
                        Session["userTypeId"] = a.user_type_id;
                        Session["user_type"] = a.user_type;
                        Session["fullname"] = a.fullname;
                        Session["deptname"] = a.dept_name;

                        return RedirectToAction("Index", "cityAdmin");
                    }

                }
                return View();
            }
        }

    }
}

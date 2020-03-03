using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmpController : Controller
    {
        tranningEntities obj = new tranningEntities();
        // GET: Emp
        public ActionResult Index()
        {
            return View(obj.FN_Disp_Rec().ToList());
        }

        // GET: Emp/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emp/Create
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            try
            {
                obj.FN_Create_Rec(employee.EmpName,employee.EmpDepartment,employee.EmpPhone,employee.EmpAddress,employee.EmpEmailId);
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Emp/Edit/5
        public ActionResult Edit(int id)
        {
            
            return View(obj.FN_Edit_Rec(id).SingleOrDefault());
        }

        // POST: Emp/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Employee employee)
        {
            try
            {

               obj.Update_Rec(employee.EmpId, employee.EmpName, employee.EmpDepartment, employee.EmpPhone, employee.EmpAddress, employee.EmpEmailId);

                    return RedirectToAction("Index");
             
            }
            catch
            {
                return View();

            }
        }

        // GET: Emp/Delete/5
        public ActionResult Delete(int id)
        {
            return View(obj.FN_Edit_Rec(id).SingleOrDefault());
        }

        // POST: Emp/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Employee employee)
        {
            try
            {
                obj.Delete_Rec(id);
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

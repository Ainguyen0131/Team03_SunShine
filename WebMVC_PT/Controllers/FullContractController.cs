using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;

namespace WebMVC_PT.Controllers
{
    public class FullContractController : Controller
    {
        QUANLYBDS_TEAM3Entities data = new QUANLYBDS_TEAM3Entities();
        // GET: FullContract
        public ActionResult Index(string strSearch, int? i)
        {
            List<Full_Contract> listtemp = data.Full_Contract.ToList();
 
        
            return View(data.Full_Contract.OrderByDescending(s => s.Full_Contract_Code).Where(x=>x.Full_Contract_Code.StartsWith(strSearch) || strSearch==null).ToList().ToPagedList(i ?? 1, 5));
        }
        public ActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Full_Contract FCt) 
        {
            data.Full_Contract.Add(FCt);
            data.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit (int ID)
        {
            Full_Contract FCt= data.Full_Contract.Find(ID);
            return View(FCt);
        }
        [HttpPost]
        public ActionResult Edit(Full_Contract FCt)
        {
            Full_Contract Fc = data.Full_Contract.Find(FCt.ID);
            Fc.Full_Contract_Code = FCt.Full_Contract_Code;
            Fc.Customer_Name = FCt.Customer_Name;
            Fc.Year_Of_Birth = FCt.Year_Of_Birth;
            Fc.SSN = FCt.SSN;
            Fc.Customer_Address = FCt.Customer_Address;
            Fc.Mobile = FCt.Mobile;
            Fc.Property_ID = FCt.Property_ID;
            Fc.Date_Of_Contract = FCt.Date_Of_Contract;
            Fc.Price = FCt.Price;
            Fc.Deposit = FCt.Deposit;
            Fc.Remain = FCt.Remain;
            Fc.Status = FCt.Status;
            data.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details (int ID)
        {
            Full_Contract FCt = data.Full_Contract.Find(ID);
            return View(FCt);
        }
        public ActionResult Delete(int? ID)
        {
            Full_Contract FCt = data.Full_Contract.Find(ID);
            return View(FCt);
        }
        [HttpPost]
        public ActionResult Delete(int ID)
        {
            Full_Contract FCt = data.Full_Contract.Find(ID);
            data.Full_Contract.Remove(FCt);
            data.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
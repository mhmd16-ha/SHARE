using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SHARE.Models;
namespace SHARE.Controllers
{
    public class ShareToolController : Controller
    {
        // GET: ShareTool
        public ActionResult Index()
        {
            List<ShareTool> ShareToolList = new List<ShareTool>();
            ShareToolList.Add(new ShareTool("غسالة", "غسالة مستعملة ", 1));
            ShareToolList.Add(new ShareTool("دراجة", "دراجة مستعملة ", 2));
            ShareToolList.Add(new ShareTool("موبيل", "موبيل مستعملة ", 0));
            ShareToolList.Add(new ShareTool("تلفاز", "تلفاز مستعملة ", 2));
            ShareToolList.Add(new ShareTool("غسالة", "غسالة مستعملة ", 1));
            return View(ShareToolList);
        }
    
        public ActionResult ReqestTool()
        {
            return Content("تم طلب الاداة");
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ShareTool model)
        {
            if (ModelState.IsValid) {
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
           
        }
    }
    }
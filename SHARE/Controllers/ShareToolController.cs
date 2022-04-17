using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Share.Business;
using SHARE.Models;
using Share1.DAL;

namespace SHARE.Controllers
{
    [HandleError]
    public class ShareToolController : Controller
    {
        // GET: ShareTool
        public ActionResult Index()
        {
            ToolRepository tool = new ToolRepository();
           List<Tool> tools= tool.GetAllTools();
            return View(tools);
        }
    
        public ActionResult ReqestTool()
        {
          
            return Content("تم طلب الاداة");
        }
        public ActionResult Create()
        {
            string user1 = "";
           
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
using SYS.AdminWeb.Models.TestModel;
using SYS.IService.Interface;
using SYS.WebCommon.Json;
using SYS.WebCommon.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SYS.AdminWeb.Controllers
{
    public class HomeController : Controller
    {
        public IIdNameService idNameService { get; set; }

        public ActionResult Index()
        {
            long id= idNameService.AddNew("活动状态", "未开始",null);
            return View(id);
        }

        public ActionResult Data(TestModel model)
        {
            if(!ModelState.IsValid)
            {
                //return Json(new AjaxResult { Status = "ok", Msg =MVCHelper.GetValidMsg(ModelState)});
                return Content(MVCHelper.GetValidMsg(ModelState));
            }
            //return Json(new AjaxResult { Status = "ok"});
            return Content("成功");
        }
    }
}
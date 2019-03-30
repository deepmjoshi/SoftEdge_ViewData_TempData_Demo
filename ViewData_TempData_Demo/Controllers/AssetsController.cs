using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewData_TempData_Demo.AssetData;
using ViewData_TempData_Demo.Models;

namespace ViewData_TempData_Demo.Controllers
{
    public class AssetsController : Controller
    {
        // GET: Assets
        public ActionResult Index()
        {
            #region using standad view
            //clsAssets.GetAllAssets();
            //var model = clsAssets.lstAssets;
            //return View(model);
            #endregion

            #region using partial view
            clsAssets.GetAllAssets();
            foreach (var asset in clsAssets.lstAssets)
            {
                ViewData[asset.AssetName] = asset;
            }
            return PartialView("_PartialAssets");
            #endregion
        }



    }
}
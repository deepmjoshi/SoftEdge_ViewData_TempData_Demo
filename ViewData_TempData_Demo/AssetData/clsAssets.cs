using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViewData_TempData_Demo.Models;

namespace ViewData_TempData_Demo.AssetData
{
    public static class clsAssets
    {
        public static List<ViewModelAssets> lstAssets = new List<ViewModelAssets>();

        public static void GetAllAssets()
        {
            ViewModelAssets objModelAssets1 = new ViewModelAssets
            {
                AssetID = 1,
                AssetName = "Fan",
                AssetCount = 2
            };
            clsAssets.lstAssets.Add(objModelAssets1);
            ViewModelAssets objModelAssets2 = new ViewModelAssets
            {
                AssetID = 2,
                AssetName = "PC",
                AssetCount = 4
            };
            clsAssets.lstAssets.Add(objModelAssets2);
        }
    }

    

}
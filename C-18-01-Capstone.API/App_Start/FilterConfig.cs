﻿using System.Web;
using System.Web.Mvc;

namespace C_18_01_Capstone.API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

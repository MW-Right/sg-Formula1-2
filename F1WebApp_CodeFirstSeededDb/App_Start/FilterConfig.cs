﻿using System.Web;
using System.Web.Mvc;

namespace F1WebApp_CodeFirstSeededDb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

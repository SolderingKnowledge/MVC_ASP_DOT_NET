﻿using System.Web;
using System.Web.Mvc;

namespace MVC_ASP_DOT_NET
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

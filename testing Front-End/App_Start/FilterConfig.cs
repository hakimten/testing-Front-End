﻿using System.Web;
using System.Web.Mvc;

namespace testing_Front_End
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odev_02_WebAPP.Filters
{
    public class AuthFilter : Attribute, IActionFilter
    {
        private readonly int auth;

        public AuthFilter(int _auth)
        {
            auth = _auth;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var action = context.HttpContext.GetRouteData().Values["action"].ToString();
            //string actionName = this.context.RouteData.Values["action"].ToString();
            switch (auth)
            {
                case 1:
                    if (action == "ThirdLevel" || action == "SecondLevel")
                        context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "Home", Action = "Index" }));
                    break;
                case 2:
                    if (action == "ThirdLevel")
                        context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "Home", Action = "Index" }));
                    break;
                case 3:
                    break;
                default:
                    context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "Home", Action = "Index" }));
                    break;
            }


            //if (auth >= 2)
            //{
            //    if (action == "SecondLevel")
            //    {
            //        return;
            //    }
            //    else if (action == "ThirdLevel")
            //    {
            //        if (auth == 3)
            //        {
            //            return;
            //        }
            //        else
            //        {
            //            context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "Home", Action = "Index" }));
            //        }
            //    }
            //}
            //else
            //{
            //    context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "Home", Action = "Error" }));
            //}
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVC.Filters
{
    public class LogActionAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine(string.Format("Now {0} method will be executed", filterContext.ActionDescriptor.ActionName));
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine(string.Format("Now {0} method is already executed", filterContext.ActionDescriptor.ActionName));
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Debug.WriteLine(string.Format("Now {0} method result will be executed", filterContext.Result.ToString()));
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Debug.WriteLine(string.Format("Now {0} method result is already executed", filterContext.Result.ToString()));
        }
    }
}
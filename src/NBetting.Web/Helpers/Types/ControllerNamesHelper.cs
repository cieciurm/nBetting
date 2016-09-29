using System;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;

namespace NBetting.Web.Helpers.Types
{
    public class ControllerNamesHelper
    {
        public static string GetActionName<TController>(Expression<Func<TController, object>> action)
            where TController : Controller
        {
            return MemberNamesGetter.GetMemberName(action);
        }

        public static string GetName<TController>()
            where TController : Controller
        {
            var controllerType = typeof(TController);
            return controllerType.Name.Remove(controllerType.Name.LastIndexOf("Controller", StringComparison.Ordinal));
        }
    }
}


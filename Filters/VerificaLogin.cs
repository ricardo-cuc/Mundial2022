using Microsoft.AspNetCore.Mvc.Filters;
using Mundial2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Mundial2022.Filters
{
    public class VerificaLogin : ActionFilterAttribute
    {
        private Usuario oUsuario;
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
          
        }
    }
}

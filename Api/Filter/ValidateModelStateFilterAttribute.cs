using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Api.Filters
{
    public class ValidateModelStateFilterAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid){
                context.HttpContext.Response.StatusCode = 400;
                context.HttpContext.Response.Headers.Clear();
                context.Result = new EmptyResult();
            }
        }
    }
}
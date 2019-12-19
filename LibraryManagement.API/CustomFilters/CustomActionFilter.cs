using LibraryManagement.API.Enum;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using System;

namespace LibraryManagement.API.CustomFilters
{
    public class CustomActionFilter : IActionFilter
    {
        #region "Private Variables"
        private readonly IConfiguration _configuration;
        #endregion

        #region "Public Constructor"
        public CustomActionFilter(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #endregion

        #region "Action Methods"
        public void OnActionExecuted(ActionExecutedContext context)
        {
            //Do nothing with this context
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //This needs to be driven from AD or Database, since this is test project, it is verified from appsetting.json
            if (_configuration["UserGroup"] == User.Admin.ToString())
                return;
            throw new UnauthorizedAccessException("Access denied");
        }
        #endregion
    }
}

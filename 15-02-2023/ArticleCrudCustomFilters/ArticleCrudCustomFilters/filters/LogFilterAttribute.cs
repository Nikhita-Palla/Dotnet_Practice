using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGrease;
using log4net;


namespace ArticleCrudCustomFilters
{
    public class LogFilterAttribute : FilterAttribute,IExceptionFilter
    { 
        private readonly ILog _logger;

        public LogFilterAttribute()
        {
            _logger = log4net.LogManager.GetLogger(typeof(LogFilterAttribute));
        }

        public void OnException(ExceptionContext filterContext)
        {
            if (filterContext == null)
            {
                throw new ArgumentNullException(nameof(filterContext));
            }

            _logger.Error("An unhandled exception occurred.", filterContext.Exception);
        }
    }
}
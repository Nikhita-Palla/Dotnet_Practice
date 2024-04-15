using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplicationASMXDEMO
{
    /// <summary>
    /// Summary description for CalculatorService
    /// </summary>
    [WebService]
   
    public class CalculatorService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}

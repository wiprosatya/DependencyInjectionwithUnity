using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjection.Service
{
    public class LoggingErrorinMail : ILogger
    {

        public string LogWithMessage(string ErrorCode, string Errormessage)
        {
            return string.Format("Looging Error message in Email by {0} - {1}", ErrorCode, Errormessage);
        }
    }
}
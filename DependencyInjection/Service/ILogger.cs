using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjection.Service
{
    public interface ILogger
    {
        string LogWithMessage(string ErrorCode, string Errormessage);
    }
}
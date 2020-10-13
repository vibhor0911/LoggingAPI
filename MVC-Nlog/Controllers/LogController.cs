using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml.Schema;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LoggingAPI.Models;

namespace LoggingAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private readonly ILogger<LogController> _logger;

        public LogController(ILogger<LogController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public void Log(LogModel myLog)
        {
            switch(myLog.logSeverity)
            {
                case LogLevel.Error:
                    _logger.LogError(myLog.message, myLog.args);
                    break;
                case LogLevel.Warning:
                    _logger.LogWarning(myLog.message, myLog.args);
                    break;
                case LogLevel.Critical:
                    _logger.LogCritical(myLog.message, myLog.args);
                    break;
                case LogLevel.Information:
                    _logger.LogInformation(myLog.message, myLog.args);
                    break;
                case LogLevel.Trace:
                    _logger.LogTrace(myLog.message, myLog.args);
                    break;
                case LogLevel.Debug:
                    _logger.LogDebug(myLog.message, myLog.args);
                    break;
                default:
                    _logger.LogInformation(myLog.message, myLog.args);
                    break;

            }
           
        }
        
    }

      
}

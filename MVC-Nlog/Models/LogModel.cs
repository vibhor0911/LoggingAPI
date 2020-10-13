using Microsoft.Extensions.Logging;
using System;

namespace LoggingAPI.Models
{
    public class LogModel
    {
        public string message { get; set; }
        public object[] args { get; set; }

        public LogLevel logSeverity { get; set; }

    }
}
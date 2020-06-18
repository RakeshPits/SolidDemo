using SolidDemo.DIP.Logger;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDemo.DIP.Factory
{
    public class LogFactory
    {
        private readonly IDictionary<LogType, ILogger> _loggerDictionary = new Dictionary<LogType, ILogger>();

        public LogFactory()
        {
            _loggerDictionary.Add(LogType.TEXT, new TextLogger());
            _loggerDictionary.Add(LogType.DB, new DbLogger());
        }

        public ILogger GetLogger(LogType logType)
        {
            return _loggerDictionary[logType];
        }
    }
}

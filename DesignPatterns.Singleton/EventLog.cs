using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DesignPatterns.Singleton
{
    class EventLog
    {
        private const string filePath = "eventLog.log";

        private static readonly EventLog instance = new EventLog(true);
        private readonly bool forceSaveToFile;
        
        private List<string> events = null;

        protected EventLog(bool forceSaveToFile = true)
        {
            this.forceSaveToFile = forceSaveToFile;
            events = Logger.GetLogList(filePath);
        }

        public static EventLog GetInstance()
        {
            return instance;
        }

        public void AddEvent(string @event)
        {
            events.Add(@event);
            if (forceSaveToFile)
            {
                Logger.Save(filePath, events);
            }
        }
    }
}

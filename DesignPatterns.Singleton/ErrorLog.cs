using System.Collections.Generic;

namespace DesignPattern.Singleton
{
    class ErrorLog
    {
        private const string filePath = "errorLog.log";

        private static ErrorLog instance;
        private readonly bool forceSaveToFile;

        
        private List<string> errors = null;

        protected ErrorLog(bool forceSaveToFile = true)
        {
            this.forceSaveToFile = forceSaveToFile;
            errors = Logger.GetLogList(filePath);
        }

        public static ErrorLog GetInstance()
        {
            if (instance == null)
                instance = new ErrorLog(true);
            return instance;
        }

        public void AddEvent(string error)
        {
            errors.Add(error);
            if (forceSaveToFile)
            {
                Logger.Save(filePath, errors);
            }
        }
    }
}

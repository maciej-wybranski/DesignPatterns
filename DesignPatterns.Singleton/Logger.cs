using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DesignPatterns.Singleton
{
    static class Logger
    {
        /// <summary>
        /// Get list of logs from file
        /// </summary>
        /// <param name="filePath">File path with list of logs</param>
        /// <returns>List of logs</returns>
        public static List<string> GetLogList(string filePath)
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllLines(filePath).ToList();
            }
            else
            {
                return new List<string>();
            }
        }

        /// <summary>
        /// The method saves the list of logs to file
        /// </summary>
        /// <param name="filePath">File path with list of logs</param>
        /// <param name="logList">List of logs</param>
        public static void Save(string filePath, List<string> logList)
        {
            File.WriteAllLines(filePath, logList.ToArray());
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Interfaces
{
    public class FileLogger : ILogger
    {
        private readonly string path;

        public FileLogger(string path)
        {
            this.path = path;
        }
        public void LogError(string message)
        {
            using (var streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine("ERROR : " + message);
            }                      
        }

        public void LogInfo(string message)
        {
            using (var streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine("INFO : " + message);
            }
        }
    }
}

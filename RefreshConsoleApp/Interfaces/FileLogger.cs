using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefreshConsoleApp.Interfaces
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message)
        {
            WriteToFile(message, "Error");
        }

        public void LogInfo(string message)
        {
            WriteToFile(message, "Info");
        }

        private void WriteToFile(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path))
            {
                streamWriter.WriteLine(messageType+": "+message);
            }
        }
    }
}

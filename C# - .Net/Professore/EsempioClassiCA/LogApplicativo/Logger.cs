using System;
using System.IO;

namespace EsempioClassiCA.LogApplicativo
{
    public class LoggerThreadSafe 
    {
        private string _pathFile;
        private object _lock = new object();

        public LoggerThreadSafe(string pathFile)
        {
            _pathFile = pathFile;
        }

        public void WriteLog(string message)
        {
            lock (_lock) // thread safe
            {
                using (StreamWriter sw = new StreamWriter(_pathFile))
                {
                    sw.WriteLine(message);
                    sw.Flush();
                    sw.Close();
                }
            }
        }
    }

    public class Logger : IDisposable
    {
        private StreamWriter _streamWriter;

        public Logger(string pathFileName)
        {
            _streamWriter = new StreamWriter(pathFileName);
        }

        public void WriteLog(string message)
        {
            _streamWriter.WriteLine(message);
        }

        public void Dispose()
        {
            _streamWriter.Flush();
            _streamWriter.Close();
            _streamWriter.Dispose();
        }
    }
}

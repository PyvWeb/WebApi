using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BsWebpub
{
    class bus_logging
    {
        private static readonly string m_EventLogPath;
        static bus_logging()
        {
            m_EventLogPath = @"D:\Project\NetCore\WebApi";

            if (!Directory.Exists(m_EventLogPath))
            {
                Directory.CreateDirectory(m_EventLogPath);
            }
        }

         static StreamWriter GetStreamWrite(string strPathFile)
        {
            StreamWriter sw;

            FileStream fs = new FileStream(strPathFile, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            sw = new StreamWriter(fs, System.Text.Encoding.Default);

            sw.BaseStream.Seek(0, SeekOrigin.End);

            return sw;
        }

        public void LogDB(string component, string message)
        {
            if (!string.IsNullOrEmpty(message) && message != Environment.NewLine)
            {
                try
                {
                    string strFile = m_EventLogPath + "\\" + DateTime.Now.ToString("yyyyMMdd") + "(" + DateTime.Now.ToString("HH") + ")" + ".log";
                    using (StreamWriter myWriter = GetStreamWrite(strFile))
                    {
                        myWriter.WriteLine(component + ":" + message);
                        myWriter.Close();
                    }
                }
                catch { }
            }
        }

    }
}

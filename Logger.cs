using System;
using System.IO;

namespace NC.Util.SqlSrv.BackupRestore
{
    public static class Logger
    {
        // ------------------------------------------------
        // CTB: 2019/10/27
        // Prefix the message to log with a date time stamp
        // ------------------------------------------------
        public static void LogMessage(string messageToLog)
        {
            string logFileName = Environment.CurrentDirectory + @"\LogFile.txt";

            using (StreamWriter file = new StreamWriter(logFileName, true))
            {
                messageToLog = $"{DateTime.Now:yyyy.MM.dd hh:mm:ss}: {messageToLog}";
                file.WriteLine(messageToLog);
            }
        }
    }
}

using System;
using System.Diagnostics;
// ReSharper disable InvalidXmlDocComment

namespace NC.Util.SqlSrv.BackupRestore
{
    public static class CommandLineHelper
    {

        public static void LaunchNotepadToViewLogFile()
        {
            try
            {
                ProcessStartInfo procStartInfo = new ProcessStartInfo
                {
                    FileName = "notepad.exe",
                    Arguments = Environment.CurrentDirectory + @"\LogFile.txt"
                };

                Process proc = new Process { StartInfo = procStartInfo };
                proc.Start();
                proc.Dispose();
            }
            catch (Exception objException)
            {
                throw;
            }

        }
    }
}

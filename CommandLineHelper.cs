using System;
using System.Diagnostics;
// ReSharper disable InvalidXmlDocComment

namespace NC.Util.SqlSrv.BackupRestore
{
    public static class CommandLineHelper
    {

        public static void ExecuteCommandSync(object command)
        {
            try
            {
                // -----------------------------------------------------------------
                // create the ProcessStartInfo using "cmd" as the program to be run,
                // and "/c " as the parameters. Incidentally, /c tells cmd that we
                // want it to execute the command that follows, and then exit.
                // -----------------------------------------------------------------
                ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + command)
                {
                    RedirectStandardOutput = true, UseShellExecute = false, CreateNoWindow = true
                };

                // ---------------------------------------------------------------------------------
                // The following commands are needed to redirect the standard output.
                // This means that it will be redirected to the Process.StandardOutput StreamReader.
                // ---------------------------------------------------------------------------------

                // -------------------------------
                // Do not create the black window.
                // -------------------------------

                // -----------------------------------------------------------------
                // Now we create a process, assign its ProcessStartInfo and start it
                // -----------------------------------------------------------------
                Process proc = new Process {StartInfo = procStartInfo};
                proc.Start();
                
                // ----------------------------
                // Get the output into a string
                // ----------------------------
                string result = proc.StandardOutput.ReadToEnd();

                // ---------------------------
                // Display the command output.
                // ---------------------------
                Console.WriteLine(result);

                proc.Dispose();
            }
            catch (Exception objException)
            {
                throw;
            }
            
        }
    }
}

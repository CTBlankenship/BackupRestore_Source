using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Cache;
using System.IO;
using System.Windows.Forms;


namespace NC.Util.SqlSrv.BackupRestore
{

    // --------------------------------------------------------------------------------
    // https://stackoverflow.com/questions/16005388/how-to-copy-a-file-on-an-ftp-server
    // --------------------------------------------------------------------------------
    public static class FTPHelper
    {

        public static void PostDataToFTP()
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://novantconsulting.com" + @"/" + "TestFile0.txt");
                request.CachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.CacheIfAvailable);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential("CTBlankenship", "Babylon5");
                // Copy the contents of the file to the request stream.  
                StreamReader sourceStream = new StreamReader(@"E:\StrataFrame.bak");
                byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
                sourceStream.Close();
                request.ContentLength = fileContents.Length;
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(fileContents, 0, fileContents.Length);
                requestStream.Close();
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Console.WriteLine("Upload File Complete, status {0}", response.StatusDescription);

                response.Close();
            }
            catch (WebException e)
            {
                Console.WriteLine(e.Message.ToString());
                String status = ((FtpWebResponse)e.Response).StatusDescription;
                Console.WriteLine(status);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public static bool CopyFile(string FtpSite = @"ftp://novantconsulting.com/SQLBackups/", string fileName = "StrataFrame.bak", string FileToCopy = @"E:\SEPARCSecurity.txt", string userName = "CTBlankenship75", string password= "Babylon5")

        {
            try
            {
                FtpWebRequest request = (FtpWebRequest) WebRequest.Create(FtpSite + fileName);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential(userName, password);
                FtpWebResponse response = (FtpWebResponse) request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                Upload(FtpSite + @"\" + FileToCopy, ToByteArray(responseStream), userName, password);
                responseStream.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());

                return false;
            }
        }

        private static Byte[] ToByteArray(Stream stream)
        {
            MemoryStream ms = new MemoryStream();
            byte[] chunk = new byte[4096];
            int bytesRead;
            while ((bytesRead = stream.Read(chunk, 0, chunk.Length)) > 0)
            {
                ms.Write(chunk, 0, bytesRead);
            }

            return ms.ToArray();
        }

        private static bool Upload(string FileName, byte[] Image, string FtpUsername, string FtpPassword)
        {
            try
            {
                System.Net.FtpWebRequest clsRequest = (System.Net.FtpWebRequest) System.Net.WebRequest.Create(FileName);
                clsRequest.Credentials = new System.Net.NetworkCredential(FtpUsername, FtpPassword);
                clsRequest.Method = System.Net.WebRequestMethods.Ftp.UploadFile;
                System.IO.Stream clsStream = clsRequest.GetRequestStream();
                clsStream.Write(Image, 0, Image.Length);

                clsStream.Close();
                clsStream.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }



    }
}

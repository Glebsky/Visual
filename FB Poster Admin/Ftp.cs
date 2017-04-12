using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FB_Poster_Admin
{
    class Ftp
    {
        public string CompleteDPath;
        private string username;
        private string pass;
        public Ftp()
        {
            CompleteDPath = "ftp://forganicplant@organicplant.ucoz.org/FbPoster/";
            username = "forganicplant";
            pass = "Tanec55";
        }




        public void UploadFile(string localFileLink)
        {
            FtpWebRequest ftpClient = (FtpWebRequest)FtpWebRequest.Create(CompleteDPath + localFileLink);
            ftpClient.Credentials = new System.Net.NetworkCredential(username, pass);
            ftpClient.Method = System.Net.WebRequestMethods.Ftp.UploadFile;
            ftpClient.UseBinary = true;
            ftpClient.KeepAlive = true;
            System.IO.FileInfo fi = new System.IO.FileInfo(localFileLink);
            ftpClient.ContentLength = fi.Length;
            byte[] buffer = new byte[4097];
            int bytes = 0;
            int total_bytes = (int)fi.Length;
            System.IO.FileStream fs = fi.OpenRead();
            System.IO.Stream rs = ftpClient.GetRequestStream();
            while (total_bytes > 0)
            {
                bytes = fs.Read(buffer, 0, buffer.Length);
                rs.Write(buffer, 0, bytes);
                total_bytes = total_bytes - bytes;
            }
            //fs.Flush();
            fs.Close();
            rs.Close();
            FtpWebResponse uploadResponse = (FtpWebResponse)ftpClient.GetResponse();
            string value = uploadResponse.StatusDescription;
            uploadResponse.Close();
        }
    }
}

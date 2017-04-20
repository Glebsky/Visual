using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Net;

namespace FbPoster
{
    class ExcelActions
    {
        string fullPath;
        public ExcelActions()
        {
            //DOWNLOAD FILE
            var client = new WebClient();
            String url = "http://organicplant.ucoz.org/FbPoster/Posts.xlsx";
            fullPath = Path.GetTempPath();
            fullPath += "Posts.xlsx";
            client.DownloadFile(url, fullPath);
        }

        public List<Post> GetPosts()
        {
            List<Post> posts = new List<Post>();
            DataTable dt = new DataTable();
            // OLE DB
            String sConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + fullPath + "; Excel 12.0 Xml;HDR=YES";
            OleDbDataAdapter adapter;
            OleDbConnection objConn = new OleDbConnection(sConnectionString);
            adapter = new OleDbDataAdapter("", sConnectionString);
            //OleDbCommand cmd = new OleDbCommand("Insert into [Maria Vasiltsova$] (Аккаунт) values('33')");
            OleDbCommand cmd = new OleDbCommand("Select * from [Posts$]");
            try
            {
                objConn.Open();
                adapter.SelectCommand = cmd;
                cmd.Connection = objConn;
                cmd.ExecuteNonQuery();
                adapter.Fill(dt);
                foreach ( DataRow dr in dt.Rows)
                {
                    posts.Add(new Post(dr[0].ToString(), dr[1].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
            finally { objConn.Close(); }

            return posts;
        }

        public void DeletePost()
        {

            // OLE DB
            String sConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + fullPath + "; Excel 12.0 Xml;HDR=YES";
            OleDbDataAdapter adapter;
            OleDbConnection objConn = new OleDbConnection(sConnectionString);
            adapter = new OleDbDataAdapter("", sConnectionString);
            OleDbCommand cmd = new OleDbCommand("update [Posts$] set [Name] = null, [Post] = null WHERE Name = 'Advice'");
            try
            {
                objConn.Open();
                adapter.SelectCommand = cmd;
                cmd.Connection = objConn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
            finally { objConn.Close(); }
        }

        public void AddPost()
        {

            // OLE DB
            String sConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + fullPath + "; Excel 12.0 Xml;HDR=YES";
            OleDbDataAdapter adapter;
            OleDbConnection objConn = new OleDbConnection(sConnectionString);
            adapter = new OleDbDataAdapter("", sConnectionString);
            OleDbCommand cmd = new OleDbCommand("Insert into [Posts$] (Name,Post) values('Advice','Posts')");
            //OleDbCommand cmd = new OleDbCommand("update [Posts$] set [Name] = null, [Post] = null WHERE Name = 'Advice'");
            try
            {
                objConn.Open();
                adapter.SelectCommand = cmd;
                cmd.Connection = objConn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
            finally { objConn.Close(); }
        }
    }
}

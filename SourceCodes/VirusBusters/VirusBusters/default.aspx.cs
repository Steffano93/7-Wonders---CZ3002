using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace VirusBusters
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string connstr = "Server=tcp:virusbusters.database.windows.net,1433;Initial Catalog=VirusBustersDB;Persist Security Info=False;User ID=VBadmin;Password=Password1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connstr);
            string cmdStr = "INSERT into dbo.users VALUES('1' , '123@gmail.com');";
            try{
                conn.Open();
                msglbl.Text = "DB conn opened";
            }
            catch(Exception ex)
            {
                msglbl.Text = ex.ToString();
            }
            
            
        }

    }
}
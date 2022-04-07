using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Loginwebapi.Models
{
    public class Dal
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public string GetLogin(Login login)
        {
            da = new SqlDataAdapter("select *from Users1 where UserName ='" + login.UserName + "' and Password = '" + login.Password + "'", con);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return "Logged IN";
            else
                return "Login Failed";
        }

    }
}
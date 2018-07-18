using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FirstWbApi.Models;
using FirstWbApi.Repository;
using System.Data;


namespace FirstWbApi.Repository
{
    public class CCLoginPage
    {
        public LoginPage getLogin(LoginPage log)
        {
            ConnectionString con = new ConnectionString();
            con.sqlcon.Open();
            var cmd = con.sqlcom;
            cmd.Connection = con.sqlcon;
            cmd.CommandText = "[dbo].[Login]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserId", log.User_Id);
            cmd.Parameters.AddWithValue("@UserName", log.UserName);
            cmd.Parameters.AddWithValue("@Password", log.Password);

            var sd1 = con.sd;
            DataTable dt = new DataTable();

            sd1.Fill(dt);
            var PostId = log.User_Id;
            var PostName = log.UserName.ToLower().ToString().Trim();
            LoginPage objlogin = new LoginPage();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objlogin.User_Id = Convert.ToInt16(dt.Rows[i]["User_id"].ToString());
                objlogin.UserName = dt.Rows[i]["UserName"].ToString().ToLower().Trim();
                objlogin.Password = dt.Rows[i]["Password"].ToString().ToLower().Trim();
                if (objlogin.User_Id == PostId)
                {
                    if (objlogin.UserName == PostName)
                    {
                        return objlogin;
                    }
                }
            }

            return objlogin;
        }


    }
}
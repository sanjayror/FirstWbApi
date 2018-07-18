using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FirstWbApi.Repository;
using System.Data;
using System.Data.SqlClient;
using FirstWbApi.Models;


namespace FirstWbApi.Repository
{
    public class CCFirstClass
    {

        public List<MemberShip> GetAll()
        {

            ConnectionString con = new ConnectionString();
            MemberShip member1 = new MemberShip();
            con.sqlcon.Open();
            var cmd = con.sqlcom;
            cmd.Connection = con.sqlcon;
            //cmd.CommandText = "select FirstPage.id, workouttype.type  ,FirstPage.Type from FirstPage inner join workouttype on FirstPage.Id = workouttype.id";
            cmd.CommandText = "Select * from Membership";
            cmd.CommandType = CommandType.Text;
            var sd1 = con.sd;
            DataTable dt = new DataTable();
            sd1.Fill(dt);
            List<MemberShip> mem = new List<MemberShip>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MemberShip member = new MemberShip();
                member.MemberID = Convert.ToInt16(dt.Rows[i]["MemberID"].ToString());
                member.Name = dt.Rows[i]["Name"].ToString().ToLower().Trim();
                member.Email = dt.Rows[i]["Email"].ToString().ToLower().Trim();
                member.Gender = dt.Rows[i]["gender"].ToString();
                member.Age = Convert.ToInt16(dt.Rows[i]["age"].ToString());
                member.Phone = Convert.ToInt32(dt.Rows[i]["Phone"].ToString());
                member.Address = dt.Rows[i]["Address"].ToString();
                member.WorkoutType = dt.Rows[i]["WorkoutType"].ToString();
                string Birthday = dt.Rows[i]["birth"].ToString();
                member.Birth = Convert.ToDateTime(Birthday);
                member.JoiningDate = Convert.ToDateTime(dt.Rows[i]["JoiningDate"].ToString());
                mem.Add(member);
            }
            var produc = (member1.meminfo = mem);
            return produc;
        }
    }
}
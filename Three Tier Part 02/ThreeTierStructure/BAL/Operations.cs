using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using BEL;
using System.Data;
using System.Data.SqlClient;

namespace BAL
{
    public class Operations
    {
        public Dbconnection db = new Dbconnection();
        public Informations info = new Informations();
        DataTable dt = new DataTable();
        public SqlCommand SelectCommand { get; set; }
        // here we declare the queries and db operations needed for the application


        public int insertEmp(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO empdata VALUES ('"+info.name+"','"+info.gender+"','"+info.address+"','"+info.education+"','"+info.username+"','"+info.password+"')";
            return db.ExeNonQuery(cmd);
        }

        public DataTable login(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " SELECT * FROM empdata WHERE Username='" +info.username+ "' and Password='" +info.password+ "'";
            return db.ExeReader(cmd);
        }

        public int insertHotel ( Informations info)
        {
            SqlCommand cmd = new SqlCommand( );
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " INSERT INTO Customer VALUES ('" + info.cname + "','" + info.date + "','" + info.date2 + "','"+info.tckimlik+"','"+info.evlistesi+"','"+info.gender+"')";
           
            return db.ExeNonQuery(cmd);
           
           
        }
    
      
    }
}

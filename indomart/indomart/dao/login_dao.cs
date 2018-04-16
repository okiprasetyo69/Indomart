using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using indomart.model;

namespace indomart.dao
{
    class login_dao
    {
        string konf = "server = 127.0.0.1; " +
                       "port = 3306;" +
                       "UID = root;" +
                       "PWD = ;" +
                       "database=db_indomart";


        MySqlConnection conn = new MySqlConnection();

        public login_dao()
        {
            conn.ConnectionString = konf;
        }

        public string login_karyawan(login_karyawan obj_login)
        {
            string status = "gagal";
            obj_login.pass = obj_login.pass.ToUpper();

            conn.Open();
            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT * FROM t_karyawan ";
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                if ((reader.GetString(0).ToString() == obj_login.nik)&&(reader.GetString(8).ToString().ToUpper() == obj_login.pass))
                {
                    status = "sukses";
                }

            }

            conn.Close();
            return status;

        }


    }
}

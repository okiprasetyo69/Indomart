using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using indomart.model;
namespace indomart.dao
{
    class status_karyawan
    {
        string konf = "server = 127.0.0.1; " +
                      "port = 3306;" +
                      "UID = root;" +
                      "PWD = ;" +
                      "database=db_indomart";

        MySqlConnection conn = new MySqlConnection();

        public status_karyawan()
        {
            conn.ConnectionString = konf;
        }

        public string status(login_karyawan obj_login)
        {
            string status_kar = "";

            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT Jabatan FROM t_karyawan WHERE Nik = '" + obj_login.nik + "'";

            
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(0).ToString() == "Kepala Toko")
                {
                    status_kar = "kepala";
                }

                else if (reader.GetString(0).ToString() == "Asissten Kepala ")
                {
                    status_kar = "ass_kepala";
                }

                else if (reader.GetString(0).ToString() == "Staff")
                {
                    status_kar = "staff";
                }

                else if (reader.GetString(0).ToString() == "Kasir")
                {
                    status_kar = "kasir";
                }



            }

            conn.Close();
            return status_kar;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using indomart.model;

namespace indomart.dao
{
    class gaji_dao
    {
        string konf = "server = localhost;" +
                      "port=3306;" +
                      "UID=root;" +
                      "PWD=;" +
                      "database=db_indomart";
        MySqlConnection conn = new MySqlConnection();

        public gaji_dao()
        {
            conn.ConnectionString = konf;
        }

        public DataSet tampilgaji()
        {
            DataSet ds = new DataSet();

            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT t_karyawan.`Nik`, t_karyawan.`Nama_Karyawan`, t_karyawan.`Jabatan` , t_penggajian.`gaji_pokok`, t_penggajian.`tunjangan` FROM t_karyawan INNER JOIN t_penggajian ON t_karyawan.`Nik` = t_penggajian.`Nik`";

            MySqlDataAdapter data = new MySqlDataAdapter(query);
            data.Fill(ds, "t_penggajian");

            conn.Close();

            return ds;
        }

        public bool insertdata(gaji g)
        {
            bool stat = false;
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "INSERT INTO t_penggajian VALUES ('" + g.nik + "'," +
                                "'" + g.gajipokok + "','" + g.tunjangan + "')";
            query.ExecuteNonQuery();
            stat = true;
            conn.Close();

            return stat;
        }

        public bool updatedata(gaji obj_gj)
        {
            bool stat = false;
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "UPDATE t_penggajian " + "SET gaji_pokok ='" + obj_gj.gajipokok + "'," + "tunjangan='" + obj_gj.tunjangan + "'" + "WHERE nik='" + obj_gj.nik + "'";
            query.ExecuteNonQuery();
            stat = true;
            conn.Close();

            return stat;
        }

        public bool hapusdata(gaji g)
        {
            bool stat = false;
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "DELETE FROM t_penggajian WHERE `nik` = '" + g.nik + "'";
            query.ExecuteNonQuery();
            stat = true;
            conn.Close();

            return stat;
        }

        public DataSet caridata_nik(gaji g)
        {
            DataSet ds = new  DataSet();
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT t_karyawan.`Nik`, t_karyawan.`Nama_Karyawan`, t_karyawan.`Jabatan` , t_penggajian.`gaji_pokok`, t_penggajian.`tunjangan` FROM t_karyawan INNER JOIN t_penggajian ON t_karyawan.`Nik` = t_penggajian.`Nik`";

            MySqlDataAdapter data = new MySqlDataAdapter(query);
            data.Fill(ds, "db_indomart");
            conn.Close();

            return ds;
        }
        public DataSet caridata_gajipokok(gaji g)
        {
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT * FROM t_penggajian WHERE gaji_pokok = '" + g.gajipokok + "'";
            
            MySqlDataAdapter data = new MySqlDataAdapter(query);
            data.Fill(ds,"db_indomart");
            conn.Close();

            return ds;
        }

        public DataSet caridata_tunjangan(gaji g)
        {
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand query = new MySqlCommand();

            query.Connection = conn;
            query.CommandText = "SELECT * FROM t_penggajian WHERE tunjangan  = '" + g.tunjangan + "'";

            MySqlDataAdapter data = new MySqlDataAdapter(query);
            data.Fill(ds, "db_indomart");
            conn.Close();

            return ds;
        }
    }
}

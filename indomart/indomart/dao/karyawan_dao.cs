using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using indomart.model;

namespace indomart.dao
{
    class karyawan_dao
    {
        string konf = "server = 127.0.0.1; " +
                       "port = 3306;" +
                       "UID = root;" +
                       "PWD = ;" +
                       "database=db_indomart";
        MySqlConnection conn = new MySqlConnection();

        public karyawan_dao()
        {
            conn.ConnectionString = konf;
        }

        public DataSet tampil_karyawan()
        {
            DataSet ds = new DataSet();

            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT Nik , Nama_Karyawan, Jenis_kelamin, ttl, tgl_lahir, Agama, Pendidikan, Jabatan FROM t_karyawan";

            MySqlDataAdapter data = new MySqlDataAdapter(query);
            data.Fill(ds, "t_karyawan");

            conn.Close();

            return ds;

        }

        public bool insertdata(karyawan k)
        {
            bool stat = false;
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;

            query.CommandText = "INSERT INTO t_karyawan VALUES ('" + k.nik + "'," + "'" + k.nama + "'," + "'" + k.jenis_kelamin + "'," + "'" + k.ttl + "'," + "'" + k.tgl_lahir + "'," + "'" + k.agama + "'," + "'" + k.pendidikan + "'," + "'" + k.jabatan + "',"+"'"+k.pass+"')";
            query.ExecuteNonQuery();
            stat = true;
            conn.Close();

            return stat;
        }

        public bool updatedata(karyawan k)
        {
            bool stat = false;
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "UPDATE t_karyawan " +
                                "SET Nama_Karyawan='" + k.nama + "'," +
                                "Jenis_Kelamin='" + k.jenis_kelamin + "'," +
                                "ttl = '" + k.ttl + "'," +
                                "tgl_lahir='" + k.tgl_lahir + "'," +
                                "Agama='" + k.agama + "'," +
                                "Pendidikan='" + k.pendidikan + "'," +
                                "Jabatan='" + k.jabatan + "' " +
                                "WHERE Nik='" + k.nik + "'";
            query.ExecuteNonQuery();
            stat = true;
            conn.Close();
            return stat;


        }

        public bool hapusdata(karyawan k)
        {
            bool stat = false;
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "DELETE FROM t_karyawan WHERE `Nik`= '" + k.nik + "'";
            query.ExecuteNonQuery();
            stat = true;
            conn.Close();

            return stat;

        }

        public DataSet carikode(karyawan k)
        {
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT * FROM t_karyawan WHERE Nik = '" + k.nik + "' ";

            MySqlDataAdapter data = new MySqlDataAdapter(query);
            data.Fill(ds, "db_indomart");
            conn.Close();

            return ds;
        }

        public DataSet carinama(karyawan k)
        {
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT * FROM t_karyawan WHERE Nama_Karyawan = '" + k.nama + "' ";

            MySqlDataAdapter data = new MySqlDataAdapter(query);
            data.Fill(ds, "db_indomart");
            conn.Close();

            return ds;

        }

        public DataSet carijabatan(karyawan k)
        {
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT * FROM t_karyawan WHERE Jabatan = '" + k.jabatan + "' ";

            MySqlDataAdapter data = new MySqlDataAdapter(query);
            data.Fill(ds, "db_indomart");
            conn.Close();

            return ds;

        }


        public DataSet carinama_kasir(karyawan k)
        {
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT Nama_Karyawan FROM t_karyawan WHERE Nik = '" + k.nik + "' ";

            MySqlDataAdapter data = new MySqlDataAdapter(query);
            data.Fill(ds, "db_indomart");
            conn.Close();

            return ds;

        }


    }
}

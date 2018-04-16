using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using indomart.model;
namespace indomart.dao
{
    class transaksi_barang_keluar_dao
    {
        string konf = " server = 127.0.0.1;" +
                      " port = 3306;" +
                      " UID = root;" +
                      " PWD = ;" +
                      "database = db_indomart";

        MySqlConnection conn = new MySqlConnection();

        public transaksi_barang_keluar_dao()
        {
            conn.ConnectionString = konf;    
        }

        public DataSet tampil_transaksi_penjualan()
        {
            DataSet ds = new DataSet();

            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT tb_transaksi_keluar.`kd_trans`, t_karyawan.`Nik`, t_karyawan.`Nama_Karyawan`,tb_transaksi_keluar.`tgl`,tb_transaksi_keluar.`total_harga` FROM tb_transaksi_keluar INNER JOIN t_karyawan ON tb_transaksi_keluar.`Nik` = t_karyawan.`Nik`";
            MySqlDataAdapter data = new MySqlDataAdapter(query);
            data.Fill(ds, "tb_transaksi_keluar");

            conn.Close();
            return ds;
        }


        public DataSet details_transaksi_penjualan(transaksi_penjualan tp)
        {
            DataSet ds = new DataSet();

            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;

            query.CommandText = "SELECT * FROM tb_keluar WHERE kd_trans = '" + tp.kd_transaksi+ "'  ";
            MySqlDataAdapter data = new MySqlDataAdapter(query);
            data.Fill(ds, "tb_keluar");

            conn.Close();
            return ds;
        }

        public bool hapus_transaksi_penjualan(transaksi_penjualan tp)
        {
            bool stat = false;
            conn.Open();
            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "DELETE FROM tb_transaksi_keluar WHERE kd_trans = '" + tp.kd_transaksi + "'";
          
            query.ExecuteNonQuery();
            stat = true;

            conn.Close();
            return stat;


        }


        

    }
}

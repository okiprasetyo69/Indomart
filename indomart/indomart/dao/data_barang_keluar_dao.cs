using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using indomart.model;
namespace indomart.dao
{
    class data_barang_keluar_dao
    {
        string konf = " server = 127.0.0.1;" +
                     " port = 3306;" +
                     " UID = root;" +
                     " PWD = ;" +
                     "database = db_indomart";

        MySqlConnection conn = new MySqlConnection();

        public data_barang_keluar_dao()
        {
            conn.ConnectionString = konf;
        }


        public DataSet tampil_temp_barang_keluar()
        {
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = " SELECT tb_barang.`kd_barang` , tb_barang.`nama_barang` , tb_barang.`harga_jual`, tb_temp_keluar.`tanggal` , tb_temp_keluar.`jumlah` FROM tb_barang INNER JOIN tb_temp_keluar ON tb_barang.`kd_barang` = tb_temp_keluar.`kd_barang` ";
            
            MySqlDataAdapter data = new MySqlDataAdapter(query);
            data.Fill(ds, "tb_temp_keluar");
            conn.Close();

            return ds;
        }

        public DataSet tampil_barang_keluar()
        {
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = " SELECT * FROM tb_keluar";

            MySqlDataAdapter data = new MySqlDataAdapter(query);
            data.Fill(ds, "tb_temp_keluar");
            conn.Close();

            return ds;
        }
        public bool input_temp_keluar(data_barang_keluar dbk)
        {
            bool stat = false;
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            
            
            query.CommandText = "INSERT INTO tb_temp_keluar VALUES ('"+dbk.kode_transaksi+"',"+"'"+dbk.kd_barang+"',"+"'"+dbk.tanggal+"',"+"'"+dbk.jumlah+"',"+"'"+dbk.total_harga()+"')";
            query.ExecuteNonQuery();
            stat = true;

            conn.Close();
            return stat;

        }

        public DataSet total_harga()
        {
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT SUM(total) AS total_harga FROM tb_temp_keluar";
            query.ExecuteNonQuery();
            MySqlDataAdapter data = new MySqlDataAdapter(query);
            data.Fill(ds, "tb_temp_keluar");


            conn.Close();
            return ds;
        }

        public bool input_transaksi_penjualan(data_barang_keluar dbk)
        {
            bool stat = false;
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "INSERT INTO tb_transaksi_keluar VALUES ('"+dbk.kode_transaksi+"',"+"'"+dbk.nik+"',"+"'"+dbk.tanggal+"',"+"'"+dbk.total_bayar+"')";
            query.ExecuteNonQuery();
            stat = true;

            conn.Close();
            return stat;
        }

        public bool hapus_temp_keluar()
        {
            bool stat = false;
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "DELETE FROM tb_temp_keluar";
            query.ExecuteNonQuery();
            stat = true;

            conn.Close();

            return stat;
        }

        public bool input_barang_keluar()
        {
            bool stat = false;
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "INSERT INTO tb_keluar SELECT * FROM tb_temp_keluar ";
            query.ExecuteNonQuery();
            stat = true;

            conn.Close();
            return stat;
        }

        public DataSet tampil_jmlah_data()
        {
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = " SELECT COUNT(kd_trans) AS jml_data FROM tb_transaksi_keluar";

            MySqlDataAdapter data = new MySqlDataAdapter(query);
            data.Fill(ds, "tb_transaksi_keluar");
            conn.Close();

            return ds;
        }

        public DataSet tampil_transaksi_barang_keluar()
        {
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = " SELECT *  FROM tb_transaksi_keluar";

            MySqlDataAdapter data = new MySqlDataAdapter(query);
            data.Fill(ds, "tb_transaksi_keluar");
            conn.Close();

            return ds;
        }


    }
}

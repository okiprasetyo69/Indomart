using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using indomart.model;

namespace indomart.dao
{
    class data_barang_dao
    {
        string konf = " server = 127.0.0.1;" +
                      " port = 3306;" +
                      " UID = root;" +
                      " PWD = ;" +
                      "database = db_indomart";
        
        MySqlConnection conn = new MySqlConnection();

        public data_barang_dao()
        {
            conn.ConnectionString = konf;
        }


        public DataSet tampildatabarang()
        {

            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand query = new MySqlCommand();

            query.Connection = conn;
            query.CommandText = "SELECT * FROM tb_barang";

            MySqlDataAdapter data = new MySqlDataAdapter(query);

            data.Fill(ds, "tb_barang");

            conn.Close();
            return ds;
           
        }

        public DataSet tampildatabarang_kosong()
        {

            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand query = new MySqlCommand();

            query.Connection = conn;
            int stock = 0;
            query.CommandText = "SELECT *  FROM tb_barang WHERE stock = '"+stock+"' ";

            MySqlDataAdapter data = new MySqlDataAdapter(query);

            data.Fill(ds, "db_indomart");

            conn.Close();
            return ds;

        }
        public bool tambah_barang(data_barang db)
        {
            bool stat = false;
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            
            query.Connection = conn;
            
            query.CommandText = "INSERT INTO tb_barang VALUES ('"+db.kd_barang+"',"+"'"+db.nama_barang+"',"+"'"+db.jenis_barang+"',"+"'"+db.jumlah_masuk+"',"+"'"+db.tgl_masuk+"',"+"'"+db.tgl_exp+"',"+"'"+db.no_rak+"',"+"'"+db.harga+"',"+"'"+db.harga+"',"+"'"+db.harga_jual+"')";
            query.ExecuteNonQuery();
            stat = true;

            return stat;
        }

        public DataSet cari_kode_barang(data_barang db )
        {
            
            DataSet ds = new DataSet();
            conn.Open();
            
            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = " SELECT * FROM tb_barang WHERE kd_barang = '"+db.kd_barang+"' ";

            
            MySqlDataAdapter data = new MySqlDataAdapter(query);

             data.Fill(ds, "tb_barang");

            conn.Close();
            return ds;

        }

        public DataSet cari_nama_barang(data_barang db)
        {
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT * FROM tb_barang WHERE nama_barang = '"+db.nama_barang+"'";

            MySqlDataAdapter data = new MySqlDataAdapter(query);
            data.Fill(ds, "tb_barang");
            conn.Close();

            return ds;
        }

        public DataSet cari_jenis_barang(data_barang db)
        {
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand query = new MySqlCommand();

            query.Connection = conn;
            query.CommandText = "SELECT * FROM tb_barang WHERE jenis_barang = '"+db.jenis_barang+"'";
            MySqlDataAdapter data = new MySqlDataAdapter(query);
            data.Fill(ds,"tb_barang");
            conn.Close();

            return ds;
                
        }


        public bool update_data(data_barang db)
        {
            bool stat = false;
            conn.Open();
            MySqlCommand query = new MySqlCommand();

            query.Connection = conn;

            query.CommandText = "UPDATE tb_barang "+" SET stock = '"+db.hitung_stock()+"' WHERE kd_barang = '"+db.kd_barang+"' ";

            query.ExecuteNonQuery();
            stat = true;
            conn.Close();

            return stat;

        }

        public bool update_barang_keluar(data_barang db)
        {
            bool stat = false;
            conn.Open();
            MySqlCommand query = new MySqlCommand();

            query.Connection = conn;

            query.CommandText = "UPDATE tb_barang " + " SET stock = '" + db.stock_brg() + "' WHERE kd_barang = '" + db.kd_barang + "' ";

            query.ExecuteNonQuery();
            stat = true;
            conn.Close();

            return stat;

        }
        public bool hapus_data_barang(data_barang db)
        {
            bool stat = false;
            conn.Open();

            MySqlCommand query = new MySqlCommand();

            query.Connection = conn;
            query.CommandText = "DELETE FROM tb_barang WHERE kd_barang = '"+db.kd_barang+"'";
            query.ExecuteNonQuery();
            stat = true;
            
            conn.Close();

            return stat;

        
        }

        public bool update_barang(data_barang db)
        {
            bool stat = false;
            conn.Open();
            
            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            //query.CommandText = "UPDATE t_mahasiswa " + "SET nama ='" + m.nama + "'," + "ttl ='" + m.tempatlahir + "'," + "tgl = '" + m.tgllahir + "'," + "alamat = '" + m.alamat + "'" + " WHERE nim = '" + m.nim + "'";

            query.CommandText = "UPDATE  tb_barang " + "SET nama_barang = '" + db.nama_barang + "'," + "jenis_barang = '" + db.jenis_barang + "'," + " harga_jual = '" + db.harga_jual + "' "+" WHERE kd_barang = '"+db.kd_barang+"' ";
            query.ExecuteNonQuery();
            stat = true;

            conn.Close();

            return stat;



        }

        public bool tambah_stock_barang(data_barang db)
        {
            bool stat = false;
            conn.Open();
            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "UPDATE tb_barang "+" SET stock = '"+db.stock+"',"+" tgl_masuk = '"+db.tgl_masuk+"',"+" tgl_exp = '"+db.tgl_exp+"' "+" WHERE kd_barang = '"+db.kd_barang+"'";
            query.ExecuteNonQuery();
            stat = true;

            conn.Close();

            return stat;
        }

        public DataSet cari_barang_kadaluarsa(data_barang db)
        {
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT * FROM tb_barang WHERE tgl_exp = '" + db.tgl_sekarang + "'";

            MySqlDataAdapter data = new MySqlDataAdapter(query);
            data.Fill(ds, "tb_barang");
            conn.Close();

            return ds;
        }




    }
}

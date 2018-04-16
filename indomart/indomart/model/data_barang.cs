using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace indomart.model
{
    class data_barang
    {
        private string _kd_barang;
        private string _nama_barang;
        private string _jenis_barang;
        
        private string _tgl_masuk;
        private string _tgl_exp;
        private string _no_rak;
        private string _status_barang;
        private double _harga;
        
        private double _harga_akhir;
        private int _jumlah_masuk;
        private double _harga_jual;
        private int _hitung_stock;
        private int _jml_keluar;
        private string _tgl_sekarang;
        

        private int _update;
        public int _stock;
        public int jumlah_masuk
        {
            get { return _jumlah_masuk; }
            set { _jumlah_masuk = value; }
        }

        public string kd_barang
        {
            get { return _kd_barang; }
            set { _kd_barang = value; }
        }

        public string nama_barang
        {
            get { return _nama_barang; }
            set { _nama_barang = value; }
        }

        public string jenis_barang
        {
            get { return _jenis_barang; }
            set { _jenis_barang = value; }
        }

        public int stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        public string tgl_masuk
        {
            get { return _tgl_masuk; }
            set { _tgl_masuk = value; }
        }

        public string tgl_exp
        {
            get { return _tgl_exp; }
            set { _tgl_exp = value; }
        }


        public string no_rak
        {
            get { return _no_rak; }
            set { _no_rak = value; }
        }

        public string status_barang
        {
            get { return _status_barang; }
            set { _status_barang = value; }
        }

        public double harga
        {
            get { return _harga; }
            set { _harga = value; }
        }

        public double harga_akhir
        {
            get { return _harga_akhir; }
            set { _harga_akhir = value; }
        }

        public double harga_jual
        {
            get { return _harga_jual;}
            set { _harga_jual = value; }
        }

        public int hitung_stock()
        {
            _hitung_stock = _stock + jumlah_masuk;
            return _hitung_stock;
        }

        public int update
        {
            get { return _update; }
            set { _update = value; }
        }


        public int jml_keluar
        {
            get { return _jml_keluar; }
            set { _jml_keluar = value; }
        }

        public int stock_brg()
        {
            return stock - jml_keluar;
        }

        public string tgl_sekarang
        {
            get { return _tgl_sekarang; }
            set { _tgl_sekarang = value; }
        }








    }
}

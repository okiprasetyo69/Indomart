using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace indomart.model
{
    class data_barang_keluar
    {
        private string _kode_transaksi;
        private string _kd_barang;
        private string _tanggal;
        private double _jumlah;
        private double _tot_harga;
        private double _harga_jual;
        private double _total_harga;
        private string _nik;
        private double _total_bayar;
        private string _kd_berikut;

        public string kode_transaksi
        {
            get { return _kode_transaksi; }
            set { _kode_transaksi = value; }
        }

        public string kd_barang
        {
            get { return _kd_barang; }
            set { _kd_barang = value; }
        }

        public string tanggal
        {
            get { return _tanggal; }
            set { _tanggal = value; }
        }

        public double jumlah
        {
            get { return _jumlah; }
            set { _jumlah = value; }
        }

        public double harga_jual
        {
            get { return _harga_jual; }
            set { _harga_jual = value; }
        }

        public double total_harga()
        {
            _total_harga = jumlah * harga_jual;
            return _total_harga;
        }


        public string nik
        {
            get { return _nik; }
            set { _nik = value; }
        }

        public double total_bayar
        {
            get { return _total_bayar; }
            set { _total_bayar = value; }
        }

        public string kd_berikut
        {
            get { return _kd_berikut; }
            set { _kd_berikut = value; }
        }



        
      



    }
}

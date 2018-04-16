using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace indomart.model
{
    class karyawan
    {
        private string _nik;
        public string nik
        {
            get { return _nik; }
            set { _nik = value; }
        }


        private string _nama;
        public string nama
        {
            get { return _nama; }
            set { _nama = value; }
        }

        private string _jenis_kelamin;
        public string jenis_kelamin
        {
            get { return _jenis_kelamin; }
            set { _jenis_kelamin = value; }
        }

        private string _ttl;
        public string ttl
        {
            get { return _ttl; }
            set { _ttl = value; }
        }

        private string _tgl_lahir;
        public string tgl_lahir
        {
            get { return _tgl_lahir; }
            set { _tgl_lahir = value; }
        }


        private string _agama;
        public string agama
        {
            get { return _agama; }
            set { _agama = value; }
        }

        private string _pendidikan;
        public string pendidikan
        {
            get { return _pendidikan; }
            set { _pendidikan = value; }
        }

        private string _jabatan;
        public string jabatan
        {
            get { return _jabatan; }
            set { _jabatan = value; }
        }

        private string _pass;
        public string pass
        {
            get { return _pass; }
            set { _pass = value; }
        }



    }
}

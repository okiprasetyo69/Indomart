using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace indomart.model
{
    class login_karyawan
    {
        private string _nik;
        private string _pass;

        public string nik
        {
            get { return _nik; }
            set { _nik = value; }
        }

        public string pass
        {
            get { return _pass; }
            set { _pass = value; }
        }

    }
}

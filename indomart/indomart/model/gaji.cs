using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace indomart.model
{
    class gaji
    {
        private string _nik;
        public string nik
        {
            get { return _nik; }
            set { _nik = value; }
        }

        private string _gajipokok;
        public string gajipokok
        {
            get { return _gajipokok; }
            set { _gajipokok = value; }
        }

        private string _tunjangan;
        public string tunjangan
        {
            get { return _tunjangan; }
            set { _tunjangan = value; }
        }
    }
}

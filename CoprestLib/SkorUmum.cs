using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoprestLib
{
    public class SkorUmum : Skor
    {
        public int skor;
        string jenis;
        string hasil;
        public override string Calculate(bool _ans1, bool _ans2, bool _ans3)
        {
            jenis = "Gejala umum";
            if (_ans1 == true)
            {
                skor++;
            }
            if (_ans2 == true)
            {
                skor++;
            }
            if (_ans3 == true)
            {
                skor++;
            }
            skor = (skor * 100) / 3;
            hasil = "Anda memiliki " + skor + " % " + jenis + " Covid 19";
            return hasil;

        }
    }
}

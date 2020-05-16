using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoprestLib
{
    public class Skor
    {
        int skor;
        string jenis;
        string hasil;
        public virtual string Calculate(bool _ans1, bool _ans2, bool _ans3)
        {
            jenis = "Jenis Gejala";
           if(_ans1 == true)
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
            hasil = "Anda memiliki " + skor + " dari 3 " + jenis + " Covid 19";
            return hasil;
        }
    }
}

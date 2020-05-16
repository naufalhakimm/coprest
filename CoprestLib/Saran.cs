using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoprestLib
{
    public class Saran
    {
        public int skor;
        public string saran;
        public int Calculate(bool _answ1, bool _answ2, bool _answ3)
        {
            if (_answ1 == true)
            {
                skor++;
            }
            if (_answ2 == true)
            {
                skor++;
            }
            if (_answ3 == true)
            {
                skor++;
            }
            return skor;
        }
        public string GenerateSaran(int skorUmum, int skorKhusus,bool travel)
        {
            if(travel == true || skorUmum>=2 || skorKhusus>=2)
            {
                saran = "Lakukan isolasi diri di rumah selama 14 hari";
                return saran;
            }
            else
            {
                saran = "Tetap jaga jarak aman, rajin mencuci tangan";
                return saran;
            }
        }
    }
}

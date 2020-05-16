using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoprestLib
{
    public class User
    {
        private string _nama;
        private int _age;

        public string Name
        {
            get { return _nama; }
            set { _nama = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLProject
{
    class SQLvarchar
    {
        public string Name;
        private int _length;
        public int Num;

        public SQLvarchar(string name, int length, int num)
        {
            Name = name;
            _length = length;
            Num = num;
        }
    }
}

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
        public int Length;
        public int Num;

        public SQLvarchar(string name, int length, int num)
        {
            Name = name;
            Length = length;
            Num = num;
        }
    }
}

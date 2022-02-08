using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLProject
{
    public class TableCommand
    {
        List<SQLint> _intList;
        List<SQLvarchar> _varcharList;
        List<SQLfloat> _floatList;

        public void AddElement(string type, string name, int length = 0)
        {
            switch (type)
            {
                case "int":
                    _intList.Add(new SQLint(name));
                    break;
                case "varchar":
                    _varcharList.Add(new SQLvarchar(name, length));
                    break;
                case "float":
                    _floatList.Add(new SQLfloat(name));
                    break;
            }
        }

        public string ConvertToCommand()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLProject
{
    public class TableCommand
    {
        List<SQLint> _intList = new List<SQLint>();
        List<SQLvarchar> _varcharList = new List<SQLvarchar>();
        List<SQLfloat> _floatList = new List<SQLfloat>();
        string _name;
        int _columnNum = 0;

        public void AddElement(string type, string name, int length = 0)
        {
            switch (type)
            {
                case "int":
                    _intList.Add(new SQLint(name, _columnNum));
                    break;
                case "varchar":
                    _varcharList.Add(new SQLvarchar(name, length, _columnNum));
                    break;
                case "float":
                    _floatList.Add(new SQLfloat(name, _columnNum));
                    break;
            }
            _columnNum++;
        }

        private int GetNumOfElements()
        {
            return _intList.Count + _varcharList.Count + _floatList.Count;
        }

        public string ConvertToCommand()
        {
            string finalText = "CREATE TABLE " + _name + "(";
            int counter = 0;
            int numOfElements = GetNumOfElements();
            for (int i = 0; i < numOfElements; i++)
            {
                foreach (var integer in _intList)
                {
                    if (integer.Num == counter)
                    {
                        finalText += integer.Name + "int";
                        if (counter != numOfElements - 1)
                        {
                            finalText += ',';
                        }
                        continue;
                    }
                }
                foreach (var text in _varcharList)
                {
                    if (text.Num == counter)
                    {
                        finalText += text.Name + " varchar(" + text.Length.ToString() + ')';
                        if (counter != numOfElements - 1)
                        {
                            finalText += ',';
                        }
                        continue;
                    }
                }
                foreach (var floating in _floatList)
                {
                    if (floating.Num == counter)
                    {
                        finalText += floating.Name + "float(10)";
                        if (counter != numOfElements - 1)
                        {
                            finalText += ',';
                        }
                        continue;
                    }
                }
            }
            return finalText + ");";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLProject
{
    public class TableCommand
    {
        private List<SQLint> _intList = new List<SQLint>();
        private List<SQLvarchar> _varcharList = new List<SQLvarchar>();
        private List<SQLfloat> _floatList = new List<SQLfloat>();
        private int _columnNum = 0;

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

        public void ClearTable()
        {
            _intList.Clear();
            _varcharList.Clear();
            _floatList.Clear();
        }

        public string GetValues()
        {
            int numOfElements = GetElementCount();
            string toReturn = string.Empty;
            int counter = 0;
            foreach (var integer in _intList)
            {
                toReturn += integer.Name + " INT";
                if (counter != numOfElements - 1)
                {
                    toReturn += ", ";
                    counter++;
                }
            }
            foreach (var floating in _floatList)
            {
                toReturn += floating.Name + " FLOAT";
                if (counter != numOfElements - 1)
                {
                    toReturn += ", ";
                    counter++;
                }

            }
            foreach (var varchar in _varcharList)
            {
                toReturn += varchar.Name + " VARCHAR(" + varchar.Length + ')';
                if (counter != numOfElements - 1)
                {
                    toReturn += ", ";
                    counter++;
                }
            }

            return toReturn;
        }

        private int GetElementCount()
        {
            return _intList.Count + _floatList.Count + _varcharList.Count;
        }

        private int GetNumOfElements()
        {
            return _intList.Count + _varcharList.Count + _floatList.Count;
        }

        public string ConvertToCommand()
        {
            string finalText = "CREATE TABLE (";
            int counter = 0;
            int numOfElements = GetNumOfElements();
            for (int i = 0; i < numOfElements; i++)
            {
                foreach (var integer in _intList)
                {
                    if (integer.Num == i)
                    {
                        finalText += integer.Name + " int";
                        if (counter != numOfElements - 1)
                        {
                            finalText += ", ";
                        }
                        continue;
                    }
                }
                foreach (var text in _varcharList)
                {
                    if (text.Num == i)
                    {
                        finalText += text.Name + " varchar(" + text.Length.ToString() + ')';
                        if (counter != numOfElements - 1)
                        {
                            finalText += ", ";
                        }
                        continue;
                    }
                }
                foreach (var floating in _floatList)
                {
                    if (floating.Num == i)
                    {
                        finalText += floating.Name + " float(10)";
                        if (counter != numOfElements - 1)
                        {
                            finalText += ", ";
                        }
                        continue;
                    }
                }
            }
            return finalText + ");";
        }

        void RefreshTextBox()
        {

        }
    }
}

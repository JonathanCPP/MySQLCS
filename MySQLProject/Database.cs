using System.Collections.Generic;

namespace MySQLProject
{
    public class Database
    {
        string _name;
        List<Table> _tables;

        public Database(string name)
        {
            _name = name;
            _tables = new List<Table>();
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public List<Table> Tables
        {
            get => _tables;
            set => _tables = value;
        }
    }
}

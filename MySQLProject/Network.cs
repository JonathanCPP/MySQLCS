using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace MySQLProject
{
    class Network
    {
        public MySql.Data.MySqlClient.MySqlConnection SQLConnection;
        public bool Connected;
        public List<Database> Databases;

        public Network()
        {
            Databases = new List<Database>();
        }

        public bool TryConnectToSQLDatabase(string ip, string username, string password)
        {
            SQLConnection = new MySql.Data.MySqlClient.MySqlConnection("server=" + ip + ";userid=" + username + ";password=" + password);

            try
            {
                SQLConnection.Open();
                do
                {
                    ConnectionState state = SQLConnection.State;

                    if (state == ConnectionState.Closed || state == ConnectionState.Broken)
                    {
                        SQLConnection.Close();
                        return false;
                    }
                } while (SQLConnection.State != ConnectionState.Open);
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }

        }

        public List<string> GetDatabases()
        {
            MySql.Data.MySqlClient.MySqlCommand command = SQLConnection.CreateCommand();
            command.CommandText = "SHOW DATABASES;";
            MySql.Data.MySqlClient.MySqlDataReader reader;
            reader = command.ExecuteReader();
            var output = new List<string>();
            while (reader.Read())
            {
                string row = "";
                for (int i = 0; i < reader.FieldCount; i++)
                    row += reader.GetValue(i).ToString();
                output.Add(row);
            }
            reader.Close();
            return output;
        }

        public List<string> ShowTables(string database)
        {
            MySql.Data.MySqlClient.MySqlCommand command = SQLConnection.CreateCommand();
            command.CommandText = "SHOW TABLES FROM `" + database + "`;";
            MySql.Data.MySqlClient.MySqlDataReader reader;
            reader = command.ExecuteReader();
            var output = new List<string>();
            while (reader.Read())
            {
                string row = "";
                for (int i = 0; i < reader.FieldCount; i++)
                    row += reader.GetValue(i).ToString();
                output.Add(row);
            }
            reader.Close();
            return output;
        }

        public void DeleteDatabase(string name)
        {
            if (name != string.Empty)
            {
                SendCommand("DROP DATABASE IF EXISTS `" + name + "`;");
            }
        }

        public void DeleteTable(string name)
        {
            name = name.Replace('\\','.');

            if (name != string.Empty)
            {
                SendCommand("DROP TABLE IF EXISTS " + name + ";");
            }
        }

        public void AddTable(string database, string name, string values)
        {
            if (database != string.Empty && name != string.Empty)
            {
                SendCommand("CREATE TABLE IF NOT EXISTS "+database+'.'+name+'('+values+");");
                MessageBox.Show("CREATE TABLE IF NOT EXISTS " + database + '.' + name + '(' + values + ");");
            }
        }

        public void AddDatabase(string name)
        {
            if (name != string.Empty)
            {
                SendCommand("CREATE DATABASE IF NOT EXISTS `" + name + "`;");
            }
        }

        public void SendCommand(string request)
        {
            try
            {
                MySql.Data.MySqlClient.MySqlCommand command = SQLConnection.CreateCommand();
                command.CommandText = request;
                command.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException) { }
        }

        public void RefreshDBData()
        {
            Databases.Clear();

            List<string> databasesNames = GetDatabases();

            for (int i = 0; i < databasesNames.Count; i++)
            {
                Databases.Add(new Database(databasesNames[i]));
                List<string> tables = ShowTables(Databases[i].Name);

                for (int x = 0; x < tables.Count; x++)
                {
                    Databases[i].Tables.Add(new Table(tables[x]));
                }
            }
        }

        public void CloseConnection()
        {
            SQLConnection.Close();
        }
    }
}

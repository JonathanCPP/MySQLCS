using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLProject
{
    public partial class TableViewer : Form
    {
        private string path;
        private Network network;
        public TableViewer(string path, Network network)
        {
            InitializeComponent();
            this.path = path;
            this.network = network;
            //LoadData();

        }

        /*public void LoadData()
        {
            dgViewTable.DataSource = 
        }*/

        
    }
}

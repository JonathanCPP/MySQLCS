using System;
using MySql.Data.MySqlClient;
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
    public partial class frmMain : Form
    {
        private Network network;
        TreeNode selected;
        TableCommand tableCommand;

        public frmMain()
        {
            InitializeComponent();
            network = new Network();
            tableCommand = new TableCommand();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            btnConnect.Enabled = false;
            if (!network.Connected)
            {
                if (network.TryConnectToSQLDatabase("localhost", "root", "root"))
                {
                    network.Connected = true;
                    ToggleButton();
                    RefreshAll();
                }
                else
                {
                    MessageBox.Show("Could not connect");
                }
            }
            else
            {
                network.CloseConnection();
                network.Connected = false;
                ToggleButton();
            }
            this.Cursor = Cursors.Default;
            btnConnect.Enabled = true;
        }

        private void RefreshTreeViewNodes()
        {
            foreach (var db in network.Databases)
            {
                tvDB.Nodes.Add(db.Name);
                foreach (var tab in db.Tables)
                {
                    tvDB.Nodes[network.Databases.IndexOf(db)].Nodes.Add(tab.Name);
                }
            }
        }

        private void ToggleButton()
        {
            if (network.Connected)
            {
                btnConnect.Text = "Disconnect";
                btnConnect.BackColor = Color.IndianRed;
                pnlDB.Enabled = true;
            }
            else
            {
                btnConnect.Text = "Connect";
                btnConnect.BackColor = Color.Green;
                pnlDB.Enabled = false;
            }
        }

        private void ClearTreeView()
        {
            tvDB.Nodes.Clear();
        }

        void RefreshAll()
        {
            network.RefreshDBData();
            ClearTreeView();
            RefreshTreeViewNodes();
        }

        private void BtnCreateDB_Click(object sender, EventArgs e)
        {
            network.AddDatabase(txbNewDB.Text);
            RefreshAll();
        }

        private void CheckDBText(object sender, EventArgs e)
        {
            if (txbNewDB.Text != string.Empty)
                btnCreateDB.Enabled = true;
            else
                btnCreateDB.Enabled = false;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (selected != null)
            {
                string ElementToDelete = selected.FullPath;
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + ElementToDelete + '?', "Delete Database", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if(selected.Level == 0)
                    {
                        network.DeleteDatabase(ElementToDelete);
                    }
                    else
                    {
                        network.DeleteTable(ElementToDelete);
                    }
                    
                }
            }
            RefreshAll();
        }

        private void BtnCreateTable_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tableCommand.GetValues());
            if (txbTableName.Text != string.Empty)
            {
                network.AddTable(selected.Text, txbTableName.Text, tableCommand.GetValues());
            }
            RefreshAll();
        }

        private void ClickTreeView(object sender, TreeNodeMouseClickEventArgs e)
        {
            selected = e.Node;
            if (selected != null)
            {
                lblSelected.Text = selected.FullPath;
                if (selected.Level == 0)
                {
                    btnCreateTable.Enabled = true;
                }
                else
                {
                    btnCreateTable.Enabled = false;
                }
            }
        }

        public void RefreshCreateTable(string text)
        {
            txbTableCreate.Text = text;
        }

        private void BtnAddElement_Click(object sender, EventArgs e)
        {
            if (cmbType.Text != string.Empty && txbColName.Text != string.Empty &&
                int.TryParse(txbLen.Text, out int num))
            {
                tableCommand.AddElement(cmbType.Text, txbColName.Text, num);
                txbTableCreate.Text = tableCommand.ConvertToCommand();
            }

        }

        private void ClearTableCreation()
        {
            txbTableCreate.Clear();
        }

        private void BtnClearTable_Click(object sender, EventArgs e)
        {
            ClearTableCreation();
            tableCommand.ClearTable();
        }
    }
}

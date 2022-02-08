﻿using System;
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
        string lastSelected;

        public frmMain()
        {
            InitializeComponent();
            network = new Network();
            lastSelected = string.Empty;
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

        private void ShowContext(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.Node.ContextMenuStrip != null && tvDB.SelectedNode != null)
            {
                lastSelected = tvDB.SelectedNode.Text;
                e.Node.ContextMenuStrip.Show();
            }
        }

        private void deleteDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            network.DeleteDatabase(lastSelected);
            RefreshAll();
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
            if (tvDB.SelectedNode != null)
            {
                string ElementToDelete = tvDB.SelectedNode.Text;
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + ElementToDelete + '?', "Delete Database", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    network.DeleteDatabase(ElementToDelete);
                }
            }
            RefreshAll();
        }

        private void BtnCreateTable_Click(object sender, EventArgs e)
        {

        }
    }
}
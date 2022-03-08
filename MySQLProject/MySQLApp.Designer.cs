namespace MySQLProject
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.pnlDB = new System.Windows.Forms.Panel();
            this.btnClearTable = new System.Windows.Forms.Button();
            this.lblSelected = new System.Windows.Forms.Label();
            this.txbTableCreate = new System.Windows.Forms.TextBox();
            this.lblColName = new System.Windows.Forms.Label();
            this.txbColName = new System.Windows.Forms.TextBox();
            this.lblTableName = new System.Windows.Forms.Label();
            this.txbTableName = new System.Windows.Forms.TextBox();
            this.lblDBName = new System.Windows.Forms.Label();
            this.btnAddElement = new System.Windows.Forms.Button();
            this.lblLen = new System.Windows.Forms.Label();
            this.txbLen = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnCreateDB = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txbNewDB = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.tvDB = new System.Windows.Forms.TreeView();
            this.pnlDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Green;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConnect.Location = new System.Drawing.Point(333, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(106, 38);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // pnlDB
            // 
            this.pnlDB.AutoScroll = true;
            this.pnlDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDB.Controls.Add(this.btnClearTable);
            this.pnlDB.Controls.Add(this.lblSelected);
            this.pnlDB.Controls.Add(this.txbTableCreate);
            this.pnlDB.Controls.Add(this.lblColName);
            this.pnlDB.Controls.Add(this.txbColName);
            this.pnlDB.Controls.Add(this.lblTableName);
            this.pnlDB.Controls.Add(this.txbTableName);
            this.pnlDB.Controls.Add(this.lblDBName);
            this.pnlDB.Controls.Add(this.btnAddElement);
            this.pnlDB.Controls.Add(this.lblLen);
            this.pnlDB.Controls.Add(this.txbLen);
            this.pnlDB.Controls.Add(this.lblType);
            this.pnlDB.Controls.Add(this.cmbType);
            this.pnlDB.Controls.Add(this.btnCreateDB);
            this.pnlDB.Controls.Add(this.btnDelete);
            this.pnlDB.Controls.Add(this.txbNewDB);
            this.pnlDB.Controls.Add(this.btnRefresh);
            this.pnlDB.Controls.Add(this.btnCreateTable);
            this.pnlDB.Controls.Add(this.tvDB);
            this.pnlDB.Enabled = false;
            this.pnlDB.Location = new System.Drawing.Point(15, 59);
            this.pnlDB.Name = "pnlDB";
            this.pnlDB.Size = new System.Drawing.Size(745, 488);
            this.pnlDB.TabIndex = 3;
            // 
            // btnClearTable
            // 
            this.btnClearTable.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnClearTable.Location = new System.Drawing.Point(147, 248);
            this.btnClearTable.Name = "btnClearTable";
            this.btnClearTable.Size = new System.Drawing.Size(116, 34);
            this.btnClearTable.TabIndex = 18;
            this.btnClearTable.Text = "Clear Table";
            this.btnClearTable.UseVisualStyleBackColor = true;
            this.btnClearTable.Click += new System.EventHandler(this.BtnClearTable_Click);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected.Location = new System.Drawing.Point(23, 21);
            this.lblSelected.MaximumSize = new System.Drawing.Size(333, 0);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(0, 15);
            this.lblSelected.TabIndex = 17;
            // 
            // txbTableCreate
            // 
            this.txbTableCreate.Location = new System.Drawing.Point(26, 288);
            this.txbTableCreate.Multiline = true;
            this.txbTableCreate.Name = "txbTableCreate";
            this.txbTableCreate.ReadOnly = true;
            this.txbTableCreate.Size = new System.Drawing.Size(333, 124);
            this.txbTableCreate.TabIndex = 16;
            // 
            // lblColName
            // 
            this.lblColName.AutoSize = true;
            this.lblColName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblColName.Location = new System.Drawing.Point(21, 177);
            this.lblColName.Name = "lblColName";
            this.lblColName.Size = new System.Drawing.Size(111, 21);
            this.lblColName.TabIndex = 15;
            this.lblColName.Text = "Column Name";
            // 
            // txbColName
            // 
            this.txbColName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txbColName.Location = new System.Drawing.Point(25, 201);
            this.txbColName.Name = "txbColName";
            this.txbColName.Size = new System.Drawing.Size(135, 29);
            this.txbColName.TabIndex = 14;
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTableName.Location = new System.Drawing.Point(21, 119);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(91, 21);
            this.lblTableName.TabIndex = 13;
            this.lblTableName.Text = "Table Name";
            // 
            // txbTableName
            // 
            this.txbTableName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTableName.Location = new System.Drawing.Point(24, 143);
            this.txbTableName.Name = "txbTableName";
            this.txbTableName.Size = new System.Drawing.Size(184, 29);
            this.txbTableName.TabIndex = 12;
            // 
            // lblDBName
            // 
            this.lblDBName.AutoSize = true;
            this.lblDBName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDBName.Location = new System.Drawing.Point(21, 61);
            this.lblDBName.Name = "lblDBName";
            this.lblDBName.Size = new System.Drawing.Size(76, 21);
            this.lblDBName.TabIndex = 11;
            this.lblDBName.Text = "DB Name";
            // 
            // btnAddElement
            // 
            this.btnAddElement.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddElement.Location = new System.Drawing.Point(25, 248);
            this.btnAddElement.Name = "btnAddElement";
            this.btnAddElement.Size = new System.Drawing.Size(116, 34);
            this.btnAddElement.TabIndex = 10;
            this.btnAddElement.Text = "Add Element";
            this.btnAddElement.UseVisualStyleBackColor = true;
            this.btnAddElement.Click += new System.EventHandler(this.BtnAddElement_Click);
            // 
            // lblLen
            // 
            this.lblLen.AutoSize = true;
            this.lblLen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblLen.Location = new System.Drawing.Point(269, 177);
            this.lblLen.Name = "lblLen";
            this.lblLen.Size = new System.Drawing.Size(62, 21);
            this.lblLen.TabIndex = 9;
            this.lblLen.Text = "Length ";
            // 
            // txbLen
            // 
            this.txbLen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txbLen.Location = new System.Drawing.Point(273, 201);
            this.txbLen.Name = "txbLen";
            this.txbLen.Size = new System.Drawing.Size(86, 29);
            this.txbLen.TabIndex = 8;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblType.Location = new System.Drawing.Point(172, 177);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(46, 21);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Type ";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "int",
            "varchar",
            "float"});
            this.cmbType.Location = new System.Drawing.Point(175, 201);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(87, 29);
            this.cmbType.TabIndex = 6;
            // 
            // btnCreateDB
            // 
            this.btnCreateDB.Enabled = false;
            this.btnCreateDB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCreateDB.Location = new System.Drawing.Point(214, 85);
            this.btnCreateDB.Name = "btnCreateDB";
            this.btnCreateDB.Size = new System.Drawing.Size(141, 29);
            this.btnCreateDB.TabIndex = 2;
            this.btnCreateDB.Text = "Create Database";
            this.btnCreateDB.UseVisualStyleBackColor = true;
            this.btnCreateDB.Click += new System.EventHandler(this.BtnCreateDB_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDelete.Location = new System.Drawing.Point(399, 428);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 34);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete DB / Table";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // txbNewDB
            // 
            this.txbNewDB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewDB.Location = new System.Drawing.Point(24, 85);
            this.txbNewDB.Name = "txbNewDB";
            this.txbNewDB.Size = new System.Drawing.Size(184, 29);
            this.txbNewDB.TabIndex = 1;
            this.txbNewDB.TextChanged += new System.EventHandler(this.CheckDBText);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRefresh.Location = new System.Drawing.Point(608, 428);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(115, 34);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Enabled = false;
            this.btnCreateTable.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCreateTable.Location = new System.Drawing.Point(26, 428);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(115, 34);
            this.btnCreateTable.TabIndex = 3;
            this.btnCreateTable.Text = "Create Table";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.BtnCreateTable_Click);
            // 
            // tvDB
            // 
            this.tvDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvDB.Location = new System.Drawing.Point(399, 17);
            this.tvDB.Name = "tvDB";
            this.tvDB.Size = new System.Drawing.Size(324, 386);
            this.tvDB.TabIndex = 0;
            this.tvDB.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ClickTreeView);
            this.tvDB.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.DoubleClickTreeView);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 559);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.pnlDB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySQL";
            this.pnlDB.ResumeLayout(false);
            this.pnlDB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel pnlDB;
        private System.Windows.Forms.TreeView tvDB;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.Button btnCreateDB;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txbNewDB;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblLen;
        private System.Windows.Forms.TextBox txbLen;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.TextBox txbTableName;
        private System.Windows.Forms.Label lblDBName;
        private System.Windows.Forms.Button btnAddElement;
        private System.Windows.Forms.Label lblColName;
        private System.Windows.Forms.TextBox txbColName;
        private System.Windows.Forms.TextBox txbTableCreate;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Button btnClearTable;
    }
}


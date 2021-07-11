namespace PROC_GEN
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDLLs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lst_Tables = new System.Windows.Forms.ListBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.lbl_tables_count = new System.Windows.Forms.Label();
            this.lst_Fields = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grp_Auth = new System.Windows.Forms.GroupBox();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.ch_SSL = new System.Windows.Forms.CheckBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grp_ObjectInfo = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTableFilter = new System.Windows.Forms.TextBox();
            this.chTablesOnly = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnTBL_Delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ch_Autonumber = new System.Windows.Forms.CheckBox();
            this.lnkRefreshTables = new System.Windows.Forms.LinkLabel();
            this.lnkRefreshColumns = new System.Windows.Forms.LinkLabel();
            this.btnColDel = new System.Windows.Forms.Button();
            this.grp_ColumnInfo = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtColumnDefault = new System.Windows.Forms.TextBox();
            this.ch_Nullable = new System.Windows.Forms.CheckBox();
            this.txtAlterColumns = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numScale = new System.Windows.Forms.NumericUpDown();
            this.cmbColumnType = new System.Windows.Forms.ComboBox();
            this.numColumnSize = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.btnColAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtColumnName = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadTableListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuttCtrXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportUserObjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importUserObjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateObjectStructureReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tpQuery = new System.Windows.Forms.TabPage();
            this.tpTableManager = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tv_Objects = new System.Windows.Forms.TreeView();
            this.cmTV_Objects = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.describeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsExecute = new System.Windows.Forms.ToolStripButton();
            this.tsStatus = new System.Windows.Forms.ToolStripLabel();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.tsNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.cmQueryArea = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toUPPERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toLowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extendedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grdQuery = new System.Windows.Forms.DataGridView();
            this.bgwQuery = new System.ComponentModel.BackgroundWorker();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grp_Auth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.grp_ObjectInfo.SuspendLayout();
            this.grp_ColumnInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColumnSize)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tpQuery.SuspendLayout();
            this.tpTableManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.cmTV_Objects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.cmQueryArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDLLs
            // 
            this.txtDLLs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDLLs.Location = new System.Drawing.Point(209, 189);
            this.txtDLLs.Multiline = true;
            this.txtDLLs.Name = "txtDLLs";
            this.txtDLLs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDLLs.Size = new System.Drawing.Size(223, 92);
            this.txtDLLs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Object DDL:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(79, 19);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(231, 20);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.Text = "muammar.yacoob@wfp.org";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(79, 45);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(231, 20);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "Bju8Lx13ESbiWwfQ4Q5-NhEEfPGND-8pzqIKIq8wxiMDJdmAFRx9_oEZstx85uFwjDalbgGiWftgbs2bQ" +
    "eAga2_VeW-kNr2phKwuXzqfG6Uk";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(79, 71);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(231, 20);
            this.txtDatabase.TabIndex = 10;
            this.txtDatabase.Text = "palantir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Database:";
            // 
            // lst_Tables
            // 
            this.lst_Tables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lst_Tables.FormattingEnabled = true;
            this.lst_Tables.HorizontalScrollbar = true;
            this.lst_Tables.Location = new System.Drawing.Point(10, 43);
            this.lst_Tables.Name = "lst_Tables";
            this.lst_Tables.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_Tables.Size = new System.Drawing.Size(183, 212);
            this.lst_Tables.TabIndex = 11;
            this.lst_Tables.SelectedIndexChanged += new System.EventHandler(this.lst_Tables_SelectedIndexChanged);
            this.lst_Tables.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lst_Tables_KeyDown);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(20, 122);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(290, 23);
            this.btn_connect.TabIndex = 12;
            this.btn_connect.Text = "&Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // lbl_tables_count
            // 
            this.lbl_tables_count.AutoSize = true;
            this.lbl_tables_count.Location = new System.Drawing.Point(8, 282);
            this.lbl_tables_count.Name = "lbl_tables_count";
            this.lbl_tables_count.Size = new System.Drawing.Size(73, 13);
            this.lbl_tables_count.TabIndex = 13;
            this.lbl_tables_count.Text = "Disconnected";
            // 
            // lst_Fields
            // 
            this.lst_Fields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lst_Fields.FormattingEnabled = true;
            this.lst_Fields.HorizontalScrollbar = true;
            this.lst_Fields.Location = new System.Drawing.Point(212, 43);
            this.lst_Fields.Name = "lst_Fields";
            this.lst_Fields.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_Fields.Size = new System.Drawing.Size(197, 95);
            this.lst_Fields.TabIndex = 14;
            this.lst_Fields.SelectedIndexChanged += new System.EventHandler(this.lst_Fields_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fields:";
            // 
            // grp_Auth
            // 
            this.grp_Auth.Controls.Add(this.numPort);
            this.grp_Auth.Controls.Add(this.ch_SSL);
            this.grp_Auth.Controls.Add(this.txtServer);
            this.grp_Auth.Controls.Add(this.label7);
            this.grp_Auth.Controls.Add(this.label2);
            this.grp_Auth.Controls.Add(this.txtUsername);
            this.grp_Auth.Controls.Add(this.label3);
            this.grp_Auth.Controls.Add(this.txtPassword);
            this.grp_Auth.Controls.Add(this.label4);
            this.grp_Auth.Controls.Add(this.txtDatabase);
            this.grp_Auth.Controls.Add(this.label5);
            this.grp_Auth.Controls.Add(this.btn_connect);
            this.grp_Auth.Location = new System.Drawing.Point(6, 6);
            this.grp_Auth.Name = "grp_Auth";
            this.grp_Auth.Size = new System.Drawing.Size(325, 178);
            this.grp_Auth.TabIndex = 22;
            this.grp_Auth.TabStop = false;
            this.grp_Auth.Text = "Authentication";
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(256, 96);
            this.numPort.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numPort.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(54, 20);
            this.numPort.TabIndex = 18;
            this.numPort.Value = new decimal(new int[] {
            5432,
            0,
            0,
            0});
            // 
            // ch_SSL
            // 
            this.ch_SSL.AutoSize = true;
            this.ch_SSL.Checked = true;
            this.ch_SSL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_SSL.Location = new System.Drawing.Point(20, 155);
            this.ch_SSL.Name = "ch_SSL";
            this.ch_SSL.Size = new System.Drawing.Size(86, 17);
            this.ch_SSL.TabIndex = 17;
            this.ch_SSL.Text = "Require SSL";
            this.ch_SSL.UseVisualStyleBackColor = true;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(79, 96);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(136, 20);
            this.txtServer.TabIndex = 15;
            this.txtServer.Text = "arabella.palantircloud.com";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Server:";
            // 
            // grp_ObjectInfo
            // 
            this.grp_ObjectInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_ObjectInfo.Controls.Add(this.label8);
            this.grp_ObjectInfo.Controls.Add(this.txtTableFilter);
            this.grp_ObjectInfo.Controls.Add(this.lst_Tables);
            this.grp_ObjectInfo.Controls.Add(this.chTablesOnly);
            this.grp_ObjectInfo.Controls.Add(this.button2);
            this.grp_ObjectInfo.Controls.Add(this.btnTBL_Delete);
            this.grp_ObjectInfo.Controls.Add(this.button1);
            this.grp_ObjectInfo.Controls.Add(this.ch_Autonumber);
            this.grp_ObjectInfo.Controls.Add(this.lnkRefreshTables);
            this.grp_ObjectInfo.Controls.Add(this.lnkRefreshColumns);
            this.grp_ObjectInfo.Controls.Add(this.txtDLLs);
            this.grp_ObjectInfo.Controls.Add(this.label1);
            this.grp_ObjectInfo.Controls.Add(this.lbl_tables_count);
            this.grp_ObjectInfo.Controls.Add(this.lst_Fields);
            this.grp_ObjectInfo.Controls.Add(this.label6);
            this.grp_ObjectInfo.Controls.Add(this.btnColDel);
            this.grp_ObjectInfo.Enabled = false;
            this.grp_ObjectInfo.Location = new System.Drawing.Point(337, 8);
            this.grp_ObjectInfo.Name = "grp_ObjectInfo";
            this.grp_ObjectInfo.Size = new System.Drawing.Size(440, 299);
            this.grp_ObjectInfo.TabIndex = 23;
            this.grp_ObjectInfo.TabStop = false;
            this.grp_ObjectInfo.Text = "Object info";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Filter:";
            // 
            // txtTableFilter
            // 
            this.txtTableFilter.Location = new System.Drawing.Point(41, 21);
            this.txtTableFilter.Name = "txtTableFilter";
            this.txtTableFilter.Size = new System.Drawing.Size(111, 20);
            this.txtTableFilter.TabIndex = 22;
            this.txtTableFilter.Text = "Consolidated";
            this.txtTableFilter.TextChanged += new System.EventHandler(this.txtTableFilter_TextChanged);
            // 
            // chTablesOnly
            // 
            this.chTablesOnly.AutoSize = true;
            this.chTablesOnly.Checked = true;
            this.chTablesOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chTablesOnly.Location = new System.Drawing.Point(11, 262);
            this.chTablesOnly.Name = "chTablesOnly";
            this.chTablesOnly.Size = new System.Drawing.Size(80, 17);
            this.chTablesOnly.TabIndex = 18;
            this.chTablesOnly.Text = "Tables only";
            this.chTablesOnly.UseVisualStyleBackColor = true;
            this.chTablesOnly.CheckedChanged += new System.EventHandler(this.chShowAll_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(415, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(17, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "D";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnTBL_Delete
            // 
            this.btnTBL_Delete.Location = new System.Drawing.Point(136, 258);
            this.btnTBL_Delete.Name = "btnTBL_Delete";
            this.btnTBL_Delete.Size = new System.Drawing.Size(57, 23);
            this.btnTBL_Delete.TabIndex = 0;
            this.btnTBL_Delete.Text = "Drop";
            this.btnTBL_Delete.UseVisualStyleBackColor = true;
            this.btnTBL_Delete.Click += new System.EventHandler(this.btnColDel_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(415, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(17, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "U";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ch_Autonumber
            // 
            this.ch_Autonumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ch_Autonumber.AutoSize = true;
            this.ch_Autonumber.Location = new System.Drawing.Point(212, 144);
            this.ch_Autonumber.Name = "ch_Autonumber";
            this.ch_Autonumber.Size = new System.Drawing.Size(83, 17);
            this.ch_Autonumber.TabIndex = 18;
            this.ch_Autonumber.Text = "Autonumber";
            this.ch_Autonumber.UseVisualStyleBackColor = true;
            // 
            // lnkRefreshTables
            // 
            this.lnkRefreshTables.AutoSize = true;
            this.lnkRefreshTables.LinkColor = System.Drawing.Color.SteelBlue;
            this.lnkRefreshTables.Location = new System.Drawing.Point(158, 27);
            this.lnkRefreshTables.Name = "lnkRefreshTables";
            this.lnkRefreshTables.Size = new System.Drawing.Size(44, 13);
            this.lnkRefreshTables.TabIndex = 17;
            this.lnkRefreshTables.TabStop = true;
            this.lnkRefreshTables.Text = "Refresh";
            this.lnkRefreshTables.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRefreshTables_LinkClicked);
            // 
            // lnkRefreshColumns
            // 
            this.lnkRefreshColumns.AutoSize = true;
            this.lnkRefreshColumns.LinkColor = System.Drawing.Color.SteelBlue;
            this.lnkRefreshColumns.Location = new System.Drawing.Point(364, 27);
            this.lnkRefreshColumns.Name = "lnkRefreshColumns";
            this.lnkRefreshColumns.Size = new System.Drawing.Size(44, 13);
            this.lnkRefreshColumns.TabIndex = 16;
            this.lnkRefreshColumns.TabStop = true;
            this.lnkRefreshColumns.Text = "Refresh";
            this.lnkRefreshColumns.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRefreshColumns_LinkClicked);
            // 
            // btnColDel
            // 
            this.btnColDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColDel.Location = new System.Drawing.Point(352, 144);
            this.btnColDel.Name = "btnColDel";
            this.btnColDel.Size = new System.Drawing.Size(57, 23);
            this.btnColDel.TabIndex = 0;
            this.btnColDel.Text = "Drop";
            this.btnColDel.UseVisualStyleBackColor = true;
            this.btnColDel.Click += new System.EventHandler(this.btnColDel_Click);
            // 
            // grp_ColumnInfo
            // 
            this.grp_ColumnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_ColumnInfo.Controls.Add(this.label13);
            this.grp_ColumnInfo.Controls.Add(this.txtColumnDefault);
            this.grp_ColumnInfo.Controls.Add(this.ch_Nullable);
            this.grp_ColumnInfo.Controls.Add(this.txtAlterColumns);
            this.grp_ColumnInfo.Controls.Add(this.label12);
            this.grp_ColumnInfo.Controls.Add(this.numScale);
            this.grp_ColumnInfo.Controls.Add(this.cmbColumnType);
            this.grp_ColumnInfo.Controls.Add(this.numColumnSize);
            this.grp_ColumnInfo.Controls.Add(this.label11);
            this.grp_ColumnInfo.Controls.Add(this.btnColAdd);
            this.grp_ColumnInfo.Controls.Add(this.label10);
            this.grp_ColumnInfo.Controls.Add(this.label9);
            this.grp_ColumnInfo.Controls.Add(this.txtColumnName);
            this.grp_ColumnInfo.Enabled = false;
            this.grp_ColumnInfo.Location = new System.Drawing.Point(337, 313);
            this.grp_ColumnInfo.Name = "grp_ColumnInfo";
            this.grp_ColumnInfo.Size = new System.Drawing.Size(440, 160);
            this.grp_ColumnInfo.TabIndex = 24;
            this.grp_ColumnInfo.TabStop = false;
            this.grp_ColumnInfo.Text = "Column info";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(291, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Default";
            // 
            // txtColumnDefault
            // 
            this.txtColumnDefault.Location = new System.Drawing.Point(294, 75);
            this.txtColumnDefault.Name = "txtColumnDefault";
            this.txtColumnDefault.Size = new System.Drawing.Size(67, 20);
            this.txtColumnDefault.TabIndex = 23;
            this.txtColumnDefault.TextChanged += new System.EventHandler(this.txtColumnDefault_TextChanged);
            // 
            // ch_Nullable
            // 
            this.ch_Nullable.AutoSize = true;
            this.ch_Nullable.Location = new System.Drawing.Point(367, 75);
            this.ch_Nullable.Name = "ch_Nullable";
            this.ch_Nullable.Size = new System.Drawing.Size(64, 17);
            this.ch_Nullable.TabIndex = 22;
            this.ch_Nullable.Text = "Nullable";
            this.ch_Nullable.UseVisualStyleBackColor = true;
            this.ch_Nullable.CheckedChanged += new System.EventHandler(this.ch_Nullable_CheckedChanged);
            // 
            // txtAlterColumns
            // 
            this.txtAlterColumns.Location = new System.Drawing.Point(10, 100);
            this.txtAlterColumns.Multiline = true;
            this.txtAlterColumns.Name = "txtAlterColumns";
            this.txtAlterColumns.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAlterColumns.Size = new System.Drawing.Size(422, 54);
            this.txtAlterColumns.TabIndex = 21;
            this.txtAlterColumns.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAlterColumns_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(233, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Scale:";
            // 
            // numScale
            // 
            this.numScale.Location = new System.Drawing.Point(236, 74);
            this.numScale.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numScale.Minimum = new decimal(new int[] {
            84,
            0,
            0,
            -2147483648});
            this.numScale.Name = "numScale";
            this.numScale.Size = new System.Drawing.Size(52, 20);
            this.numScale.TabIndex = 12;
            this.numScale.ValueChanged += new System.EventHandler(this.numScale_ValueChanged);
            // 
            // cmbColumnType
            // 
            this.cmbColumnType.FormattingEnabled = true;
            this.cmbColumnType.Items.AddRange(new object[] {
            "CHAR",
            "VARCHAR2",
            "NCHAR",
            "NVARCHAR2",
            "NUMBER",
            "LONG",
            "FLOAT",
            "DATE",
            "RAW",
            "LONGRAW",
            "ROWID",
            "UROWID",
            "BLOB",
            "CLOB",
            "NCLOB",
            "BFILE"});
            this.cmbColumnType.Location = new System.Drawing.Point(10, 73);
            this.cmbColumnType.Name = "cmbColumnType";
            this.cmbColumnType.Size = new System.Drawing.Size(162, 21);
            this.cmbColumnType.TabIndex = 11;
            this.cmbColumnType.Text = "NUMBER";
            this.cmbColumnType.SelectedIndexChanged += new System.EventHandler(this.cmbColumnType_SelectedIndexChanged);
            // 
            // numColumnSize
            // 
            this.numColumnSize.Location = new System.Drawing.Point(178, 74);
            this.numColumnSize.Maximum = new decimal(new int[] {
            38,
            0,
            0,
            0});
            this.numColumnSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numColumnSize.Name = "numColumnSize";
            this.numColumnSize.Size = new System.Drawing.Size(52, 20);
            this.numColumnSize.TabIndex = 10;
            this.numColumnSize.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numColumnSize.ValueChanged += new System.EventHandler(this.numColumnSize_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(179, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Size:";
            // 
            // btnColAdd
            // 
            this.btnColAdd.Location = new System.Drawing.Point(357, 31);
            this.btnColAdd.Name = "btnColAdd";
            this.btnColAdd.Size = new System.Drawing.Size(75, 23);
            this.btnColAdd.TabIndex = 6;
            this.btnColAdd.Text = "Add/Modify";
            this.btnColAdd.UseVisualStyleBackColor = true;
            this.btnColAdd.Click += new System.EventHandler(this.btnColAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Column Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Column Name:";
            // 
            // txtColumnName
            // 
            this.txtColumnName.Location = new System.Drawing.Point(11, 34);
            this.txtColumnName.Name = "txtColumnName";
            this.txtColumnName.Size = new System.Drawing.Size(340, 20);
            this.txtColumnName.TabIndex = 1;
            this.txtColumnName.TextChanged += new System.EventHandler(this.txtColumnName_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 532);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(795, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_status
            // 
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(79, 17);
            this.lbl_status.Text = "Disconnected";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.saveToFileToolStripMenuItem,
            this.reloadTableListToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.connectToolStripMenuItem.Text = "&Connect";
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.saveToFileToolStripMenuItem.Text = "&Save as sql file...";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.saveToFileToolStripMenuItem_Click);
            // 
            // reloadTableListToolStripMenuItem
            // 
            this.reloadTableListToolStripMenuItem.Name = "reloadTableListToolStripMenuItem";
            this.reloadTableListToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.reloadTableListToolStripMenuItem.Text = "&Reload table list";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(155, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuttCtrXToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // cuttCtrXToolStripMenuItem
            // 
            this.cuttCtrXToolStripMenuItem.Name = "cuttCtrXToolStripMenuItem";
            this.cuttCtrXToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cuttCtrXToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportUserObjectsToolStripMenuItem,
            this.importUserObjectsToolStripMenuItem,
            this.generateObjectStructureReportToolStripMenuItem,
            this.toolStripSeparator3,
            this.optionsToolStripMenuItem1});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.optionsToolStripMenuItem.Text = "&Tools";
            // 
            // exportUserObjectsToolStripMenuItem
            // 
            this.exportUserObjectsToolStripMenuItem.Name = "exportUserObjectsToolStripMenuItem";
            this.exportUserObjectsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.exportUserObjectsToolStripMenuItem.Text = "E&xport user objects...";
            this.exportUserObjectsToolStripMenuItem.Click += new System.EventHandler(this.exportUserObjectsToolStripMenuItem_Click);
            // 
            // importUserObjectsToolStripMenuItem
            // 
            this.importUserObjectsToolStripMenuItem.Name = "importUserObjectsToolStripMenuItem";
            this.importUserObjectsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.importUserObjectsToolStripMenuItem.Text = "&Import user objects...";
            // 
            // generateObjectStructureReportToolStripMenuItem
            // 
            this.generateObjectStructureReportToolStripMenuItem.Name = "generateObjectStructureReportToolStripMenuItem";
            this.generateObjectStructureReportToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.generateObjectStructureReportToolStripMenuItem.Text = "Generate objects &report...";
            this.generateObjectStructureReportToolStripMenuItem.Click += new System.EventHandler(this.generateObjectStructureReportToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(203, 6);
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(206, 22);
            this.optionsToolStripMenuItem1.Text = "&Options...";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerOnlineToolStripMenuItem,
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // registerOnlineToolStripMenuItem
            // 
            this.registerOnlineToolStripMenuItem.Name = "registerOnlineToolStripMenuItem";
            this.registerOnlineToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registerOnlineToolStripMenuItem.Text = "&Register online";
            this.registerOnlineToolStripMenuItem.Click += new System.EventHandler(this.registerOnlineToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tpQuery);
            this.tabControl2.Controls.Add(this.tpTableManager);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 24);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(795, 508);
            this.tabControl2.TabIndex = 28;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tpQuery
            // 
            this.tpQuery.Controls.Add(this.grp_Auth);
            this.tpQuery.Controls.Add(this.grp_ObjectInfo);
            this.tpQuery.Controls.Add(this.grp_ColumnInfo);
            this.tpQuery.Location = new System.Drawing.Point(4, 22);
            this.tpQuery.Name = "tpQuery";
            this.tpQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuery.Size = new System.Drawing.Size(787, 482);
            this.tpQuery.TabIndex = 0;
            this.tpQuery.Text = "Table Manager";
            this.tpQuery.UseVisualStyleBackColor = true;
            // 
            // tpTableManager
            // 
            this.tpTableManager.Controls.Add(this.splitContainer2);
            this.tpTableManager.Location = new System.Drawing.Point(4, 22);
            this.tpTableManager.Name = "tpTableManager";
            this.tpTableManager.Padding = new System.Windows.Forms.Padding(3);
            this.tpTableManager.Size = new System.Drawing.Size(787, 482);
            this.tpTableManager.TabIndex = 1;
            this.tpTableManager.Text = "Query Tester";
            this.tpTableManager.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label14);
            this.splitContainer2.Panel1.Controls.Add(this.textBox1);
            this.splitContainer2.Panel1.Controls.Add(this.tv_Objects);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(781, 476);
            this.splitContainer2.SplitterDistance = 179;
            this.splitContainer2.TabIndex = 1;
            // 
            // tv_Objects
            // 
            this.tv_Objects.ContextMenuStrip = this.cmTV_Objects;
            this.tv_Objects.HideSelection = false;
            this.tv_Objects.Location = new System.Drawing.Point(0, 30);
            this.tv_Objects.Name = "tv_Objects";
            this.tv_Objects.Size = new System.Drawing.Size(179, 446);
            this.tv_Objects.TabIndex = 20;
            this.tv_Objects.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_Objects_AfterSelect);
            this.tv_Objects.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_Objects_NodeMouseClick);
            this.tv_Objects.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tv_Objects_KeyDown);
            // 
            // cmTV_Objects
            // 
            this.cmTV_Objects.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryToolStripMenuItem,
            this.describeToolStripMenuItem,
            this.dropToolStripMenuItem});
            this.cmTV_Objects.Name = "cmTV_Objects";
            this.cmTV_Objects.Size = new System.Drawing.Size(120, 70);
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryToolStripMenuItem.Image = global::PROC_GEN.Properties.Resources.Gear;
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.queryToolStripMenuItem.Text = "Query";
            this.queryToolStripMenuItem.Click += new System.EventHandler(this.queryToolStripMenuItem_Click);
            // 
            // describeToolStripMenuItem
            // 
            this.describeToolStripMenuItem.Image = global::PROC_GEN.Properties.Resources.info;
            this.describeToolStripMenuItem.Name = "describeToolStripMenuItem";
            this.describeToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.describeToolStripMenuItem.Text = "Describe";
            this.describeToolStripMenuItem.Click += new System.EventHandler(this.describeToolStripMenuItem_Click);
            // 
            // dropToolStripMenuItem
            // 
            this.dropToolStripMenuItem.Image = global::PROC_GEN.Properties.Resources.No;
            this.dropToolStripMenuItem.Name = "dropToolStripMenuItem";
            this.dropToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.dropToolStripMenuItem.Text = "Drop";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.txtQuery);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grdQuery);
            this.splitContainer1.Size = new System.Drawing.Size(598, 476);
            this.splitContainer1.SplitterDistance = 271;
            this.splitContainer1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsExecute,
            this.tsStatus,
            this.tsDelete,
            this.tsNew,
            this.toolStripSeparator1,
            this.tsSave,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 244);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(596, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // tsExecute
            // 
            this.tsExecute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsExecute.Image = global::PROC_GEN.Properties.Resources.Q;
            this.tsExecute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsExecute.Name = "tsExecute";
            this.tsExecute.Size = new System.Drawing.Size(23, 22);
            this.tsExecute.Text = "Execute Query";
            this.tsExecute.ToolTipText = "Execute Query - F8";
            this.tsExecute.Click += new System.EventHandler(this.tsExecute_Click);
            // 
            // tsStatus
            // 
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(82, 22);
            this.tsStatus.Text = "Disconnected.";
            // 
            // tsDelete
            // 
            this.tsDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDelete.Image = global::PROC_GEN.Properties.Resources.No;
            this.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(23, 22);
            this.tsDelete.Text = "Delete selected rows";
            this.tsDelete.Click += new System.EventHandler(this.tsDelete_Click);
            // 
            // tsNew
            // 
            this.tsNew.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsNew.Image = global::PROC_GEN.Properties.Resources.Add;
            this.tsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNew.Name = "tsNew";
            this.tsNew.Size = new System.Drawing.Size(23, 22);
            this.tsNew.Text = "Add new row";
            this.tsNew.Click += new System.EventHandler(this.tsNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsSave
            // 
            this.tsSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSave.Image = global::PROC_GEN.Properties.Resources.icn_save_xsmall;
            this.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(23, 22);
            this.tsSave.Text = "Save";
            this.tsSave.Click += new System.EventHandler(this.tsSave_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery.ContextMenuStrip = this.cmQueryArea;
            this.txtQuery.Enabled = false;
            this.txtQuery.Location = new System.Drawing.Point(3, 3);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtQuery.Size = new System.Drawing.Size(589, 238);
            this.txtQuery.TabIndex = 0;
            this.txtQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuery_KeyDown);
            // 
            // cmQueryArea
            // 
            this.cmQueryArea.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toUPPERToolStripMenuItem,
            this.toLowerToolStripMenuItem,
            this.toolStripSeparator2,
            this.clearToolStripMenuItem,
            this.executeToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.cmQueryArea.Name = "cmQueryArea";
            this.cmQueryArea.Size = new System.Drawing.Size(125, 120);
            // 
            // toUPPERToolStripMenuItem
            // 
            this.toUPPERToolStripMenuItem.Name = "toUPPERToolStripMenuItem";
            this.toUPPERToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.toUPPERToolStripMenuItem.Text = "To &UPPER";
            this.toUPPERToolStripMenuItem.Click += new System.EventHandler(this.toUPPERToolStripMenuItem_Click);
            // 
            // toLowerToolStripMenuItem
            // 
            this.toLowerToolStripMenuItem.Name = "toLowerToolStripMenuItem";
            this.toLowerToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.toLowerToolStripMenuItem.Text = "To &lower";
            this.toLowerToolStripMenuItem.Click += new System.EventHandler(this.toLowerToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(121, 6);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.Image = global::PROC_GEN.Properties.Resources.Q;
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.executeToolStripMenuItem.Text = "&Execute";
            this.executeToolStripMenuItem.Click += new System.EventHandler(this.executeToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compactToolStripMenuItem,
            this.extendedToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.formatToolStripMenuItem.Text = "&Format";
            // 
            // compactToolStripMenuItem
            // 
            this.compactToolStripMenuItem.Name = "compactToolStripMenuItem";
            this.compactToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.compactToolStripMenuItem.Text = "&Compact";
            this.compactToolStripMenuItem.Click += new System.EventHandler(this.compactToolStripMenuItem_Click);
            // 
            // extendedToolStripMenuItem
            // 
            this.extendedToolStripMenuItem.Name = "extendedToolStripMenuItem";
            this.extendedToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.extendedToolStripMenuItem.Text = "E&xtended";
            this.extendedToolStripMenuItem.Click += new System.EventHandler(this.extendedToolStripMenuItem_Click);
            // 
            // grdQuery
            // 
            this.grdQuery.AllowUserToOrderColumns = true;
            this.grdQuery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdQuery.Location = new System.Drawing.Point(0, 0);
            this.grdQuery.Name = "grdQuery";
            this.grdQuery.RowHeadersWidth = 25;
            this.grdQuery.Size = new System.Drawing.Size(596, 199);
            this.grdQuery.TabIndex = 0;
            this.grdQuery.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grdQuery_DataError);
            // 
            // bgwQuery
            // 
            this.bgwQuery.WorkerSupportsCancellation = true;
            this.bgwQuery.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwQuery_DoWork);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Filter:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "Consolidated";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 554);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(803, 581);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Postgre Swift";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.grp_Auth.ResumeLayout(false);
            this.grp_Auth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.grp_ObjectInfo.ResumeLayout(false);
            this.grp_ObjectInfo.PerformLayout();
            this.grp_ColumnInfo.ResumeLayout(false);
            this.grp_ColumnInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColumnSize)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tpQuery.ResumeLayout(false);
            this.tpTableManager.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.cmTV_Objects.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.cmQueryArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdQuery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDLLs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lst_Tables;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label lbl_tables_count;
        private System.Windows.Forms.ListBox lst_Fields;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grp_Auth;
        private System.Windows.Forms.GroupBox grp_ObjectInfo;
        private System.Windows.Forms.GroupBox grp_ColumnInfo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadTableListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuttCtrXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lbl_status;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtColumnName;
        private System.Windows.Forms.Button btnColAdd;
        private System.Windows.Forms.ComboBox cmbColumnType;
        private System.Windows.Forms.NumericUpDown numColumnSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnColDel;
        private System.Windows.Forms.NumericUpDown numScale;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAlterColumns;
        private System.Windows.Forms.LinkLabel lnkRefreshTables;
        private System.Windows.Forms.LinkLabel lnkRefreshColumns;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtColumnDefault;
        private System.Windows.Forms.CheckBox ch_Nullable;
        private System.Windows.Forms.CheckBox ch_Autonumber;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.CheckBox chTablesOnly;
        private System.Windows.Forms.Button btnTBL_Delete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tpQuery;
        private System.Windows.Forms.TabPage tpTableManager;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.DataGridView grdQuery;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsExecute;
        private System.Windows.Forms.ToolStripLabel tsStatus;
        private System.Windows.Forms.ToolStripButton tsDelete;
        private System.Windows.Forms.ToolStripButton tsNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsSave;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView tv_Objects;
        private System.Windows.Forms.ContextMenuStrip cmTV_Objects;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem describeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmQueryArea;
        private System.Windows.Forms.ToolStripMenuItem toUPPERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toLowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extendedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportUserObjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importUserObjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateObjectStructureReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registerOnlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.ComponentModel.BackgroundWorker bgwQuery;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ch_SSL;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTableFilter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
    }
}


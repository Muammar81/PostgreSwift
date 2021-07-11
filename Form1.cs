using System;
using System.Data;
using System.Data.OracleClient;
using System.IO;
using System.Windows.Forms;
using Npgsql;
using QSoft;


namespace PROC_GEN
{
    public partial class Form1 : Form
    {
        OracleDataGridViewHelper c;

        string strTemp = String.Empty;
        string[] strFields;
        string strFields_with_commas;
        string strINSERT_PROC, strUPDATE_PROC, strDELETE_PROC, strPROC_PARAMS, strPROC_VALS;
        string str_cutTableName;
        string selectedItems;

        NpgsqlDataReader dataReader;
        NpgsqlCommand cmd;
        NpgsqlDataAdapter adap;
        private string connectionString;
        private Authentication authForm;
        NpgsqlConnection con;



        public Form1(string connectionString, Authentication authForm)
        {
            NpgsqlConnectionStringBuilder sb = new NpgsqlConnectionStringBuilder(connectionString);
            this.userName = sb.Username;
            this.password = sb.Password;

            this.connectionString = connectionString;
            this.authForm = authForm;

            InitializeComponent();
            this.Show();


        }




        private void DBDisconnect()
        {
            con.Close();
            lbl_status.Text = "Disconnected";
            connectToolStripMenuItem.Text = "&Connect";

            lst_Tables.Items.Clear();
            lst_Fields.Items.Clear();
            lbl_tables_count.Text = "Idle";
            tv_Objects.Nodes.Clear();
            txtDLLs.Clear();
            txtColumnDefault.Clear();
            txtColumnName.Text = " ";
            numColumnSize.Value = 1;
            numScale.Value = 0;
            ch_Autonumber.Checked = false;
            ch_Nullable.Checked = false;

            cmbColumnType.Text = String.Empty;
            txtAlterColumns.Clear();

            grp_ObjectInfo.Enabled = false;
            grp_ColumnInfo.Enabled = false;
            txtQuery.Enabled = false;
            tsStatus.Text = "Disconnected.";




            authForm.Show();
            this.Hide();
        }



        private void PopulateObjectList(bool bTablesOnly)
        {
            /*            string cmdString = @"SELECT * FROM pg_catalog.pg_tables" +
                                            "WHERE schemaname != 'pg_catalog' AND schemaname != 'information_schema';";*/

            string cmdString = $"SELECT tablename FROM pg_catalog.pg_tables WHERE tablename like '%{txtTableFilter.Text}%' ORDER BY tablename ASC;';";
            //cmd = null;
            dataReader = null;

            con = new NpgsqlConnection(connectionString);
            con.Open();

            if (bTablesOnly)

                cmd = new NpgsqlCommand(cmdString, con);

            else
                cmd = new NpgsqlCommand(cmdString, con); //change string

            //adap = new NpgsqlDataAdapter(cmd);

            dataReader = cmd.ExecuteReader(CommandBehavior.Default);

            string strTemp = String.Empty;
            lst_Tables.Items.Clear();


            while (dataReader.Read())
            {
                strTemp = dataReader.GetString(0);
                if (!strTemp.Contains("$"))
                    lst_Tables.Items.Add(strTemp);
            }

            strTemp = String.Empty;

            string strObjects;
            if (bTablesOnly)
                strObjects = " Tables ";
            else
                strObjects = " Objects ";





            lbl_tables_count.Text = lst_Tables.Items.Count + strObjects + "were found.";

            //dataReader.Close();
        }



        bool b_Multiple;


        private void PopulateColumns(string strTableName)
        {

            con = new NpgsqlConnection(connectionString);
            con.Open();
            try
            {

                lst_Fields.Items.Clear();
                if (lst_Tables.SelectedItems.Count == 1)
                {
                    lst_Fields.Enabled = true;
                    btnColDel.Enabled = true;

                    #region Retrieving Columns
                    /////////Preparing strFields
                    /*                    cmd = new NpgsqlCommand(@"select column_name " +//,data_type 
                                                                "from information_schema.columns " +
                                                                $"where table_name = '{strTableName}';", con);*/

                    cmd = new NpgsqlCommand($"SELECT column_name FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{strTableName}';", con);
                    //adap = new NpgsqlDataAdapter(cmd);
                    //dataReader.Close();
                    dataReader = null;

                    strTemp = String.Empty;
                    dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                        strTemp += dataReader.GetString(0) + ",";

                    if (strTemp.Length > 0)
                        strFields_with_commas = strTemp.Substring(0, strTemp.Length - 1);
                    else
                        strFields_with_commas = strTemp;

                    strFields = strFields_with_commas.Split(',');
                    /////////////////////////////


                    //populating lst_Fields
                    lst_Fields.Items.Clear();

                    lst_Fields.Items.AddRange(strFields);
                    if (lst_Fields.Items.Count > 0)
                        lst_Fields.SelectedItem = lst_Fields.Items[0];


                    /////////////////////////
                    #endregion
                }
                else
                {
                    lst_Fields.Enabled = false;
                    btnColDel.Enabled = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            //oraDataReader.Close();
        }


        string[] ar_tables;

        private string PopulateObjectDLL(string strObjectType, string strTable, string strUser)
        {
            cmd = new NpgsqlCommand(
            @"SELECT dbms_metadata.get_ddl('" + strObjectType + "','" + strTable + "','" + strUser + @"')
            FROM DUAL", con);

            string strTemp = String.Empty;

            dataReader = null;
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
                strTemp += dataReader.GetString(0) + "\r\n";

            strTemp = strTemp.Replace("  ", "").Replace("\t", "\r\n");
            return strTemp;
        }

        private string GetObjectType(string strObjectName)
        {
            NpgsqlCommand _oc = new NpgsqlCommand(
            @"SELECT DISTINCT OBJECT_TYPE FROM dba_objects
            WHERE OBJECT_NAME = '" + strObjectName + "'", con);

            string _strTemp = String.Empty;


            NpgsqlDataReader _oraDataReader = _oc.ExecuteReader();
            while (_oraDataReader.Read())
                _strTemp += _oraDataReader.GetString(0);

            return _strTemp;
        }

        private void lst_Tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            //con = new NpgsqlConnection(connectionString);
            //con.Open();
            try
            {
                #region generate table list
                selectedItems = String.Empty;
                if (lst_Tables.SelectedItems.Count > 1)
                {
                    for (int x = 0; x < lst_Tables.SelectedItems.Count; x++)
                        selectedItems += lst_Tables.SelectedItems[x] + ",";

                    selectedItems = selectedItems.Substring(0, selectedItems.Length - 1);
                    b_Multiple = true;

                    ar_tables = new string[selectedItems.Split(',').Length];
                    ar_tables = selectedItems.Split(',');
                }
                else
                {
                    selectedItems = lst_Tables.Items[lst_Tables.SelectedIndex].ToString();
                    b_Multiple = false;

                    ar_tables = new string[1];
                    ar_tables[0] = selectedItems;
                }
                #endregion
                PopulateColumns(lst_Tables.SelectedItems[0].ToString());




                ///////////////// Generating Object(s) DLL
                string strSelectedObjectType = String.Empty;
                txtDLLs.Clear();

                foreach (string strObjectName in ar_tables)
                {
                    strSelectedObjectType = GetObjectType(strObjectName);
                    txtDLLs.Text += PopulateObjectDLL(strSelectedObjectType, strObjectName, userName) + "/\r\n\r\n";
                }
                ///////////////////////////////////////
            }
            catch (Exception) { }
        }



        bool CTRL_A;
        private void lst_Tables_KeyDown(object sender, KeyEventArgs e)
        {
            CTRL_A = true;


            int x = 0;
            if (e.Control && e.KeyValue == 65)
            {
                for (; x < lst_Tables.Items.Count; x++)
                    lst_Tables.SelectedIndex = x;
                //lst_Tables.SetSelected(x,true);

            }

            CTRL_A = false;


        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = @"SQL Files|*.sql";
            saveFileDialog1.FileName = userName + "_PROCS.sql";
            saveFileDialog1.ShowDialog();

            string FinalFileName = saveFileDialog1.FileName.ToLower().EndsWith(".sql") ? saveFileDialog1.FileName : saveFileDialog1.FileName + ".sql";

            StreamWriter sw = new StreamWriter(FinalFileName);

            sw.Write("CONN " + userName + "/" + password + ((database.Length) > 0 ? @"@" + database : "") + database + "\r\n/\r\n" + userName + "\r\n" + userName + "\r\nEXIT\r\n/\r\n");
            sw.Close();

            FileStream fs = new FileStream(FinalFileName.Replace(".sql", "") + "_SETUP.bat", FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();

            sw = new StreamWriter(FinalFileName.Replace(".sql", "") + "_SETUP.bat", false);
            sw.Write(@"@PROMPT $Z
CLS
@SQLPLUS " + userName + @"/" + password + ((database.Length) > 0 ? @"@" + database : "") + @" @""" + FinalFileName.Replace(System.Environment.CurrentDirectory, ".") + @"""
@ECHO.
@ECHO " + Convert.ToString(lst_Tables.SelectedItems.Count * 3) + @" procedures were created successfully!
@PAUSE
@EXIT");

            sw.Close();
        }

        private void btnColDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (lst_Fields.SelectedItems.Count > 0)
                {
                    string Cols = String.Empty;
                    foreach (string tmp in lst_Fields.SelectedItems)
                        Cols += tmp + ", ";

                    if (Cols.Length > 1)
                        Cols = Cols.Substring(0, Cols.Length - 2);
                    //Cols = Cols.Replace(";", "\r\n");

                    DialogResult dr = MessageBox.Show("Are you sure you want to drop the column(s):\r\n" + Cols + "\r\nFrom " + lst_Tables.SelectedItem.ToString() + "?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        foreach (string c in Cols.Trim().Split(','))
                        {
                            cmd.CommandText = @"ALTER TABLE " + lst_Tables.SelectedItem.ToString() + " DROP COLUMN " + c;
                            cmd.ExecuteNonQuery();
                        }
                        PopulateColumns(lst_Tables.SelectedItems[0].ToString());
                    }
                }
                else
                    MessageBox.Show("No columns were selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception) { }
        }

        string[] str_AlterCommand;
        private void btnColAdd_Click(object sender, EventArgs e)
        {
            if (txtAlterColumns.Text.Length > 0)
            {
                int iColsEffected = 0;
                string tmp = txtAlterColumns.Text.Replace("\r\n/\r\n", ":");
                tmp = tmp.Substring(0, tmp.Length - 1);
                string[] alterLines = tmp.Split(':');
                foreach (string strCommandLine in alterLines)
                {
                    cmd.CommandText = strCommandLine;
                    cmd.ExecuteNonQuery();
                    iColsEffected++;
                }
                if (lst_Tables.SelectedItems.Count > 0)
                    PopulateColumns(lst_Tables.SelectedItems[0].ToString());
                MessageBox.Show(iColsEffected + " Table(s) altered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void GenerateColumnDDL()
        {
            if (txtColumnName.Text.Length > 0)
            {
                str_AlterCommand = new string[ar_tables.Length];

                if (cmbColumnType.Text == "NUMBER")
                {
                    for (int x = 0; x < ar_tables.Length; x++)
                        str_AlterCommand[x] = "ALTER TABLE " + ar_tables[x] + " ADD " + txtColumnName.Text + " " + cmbColumnType.Text + "(" + numColumnSize.Value.ToString() + "," + numScale.Value + ")";
                }
                else
                {
                    for (int x = 0; x < ar_tables.Length; x++)
                        str_AlterCommand[x] = "ALTER TABLE " + ar_tables[x] + " ADD " + txtColumnName.Text + " " + cmbColumnType.Text + "(" + numColumnSize.Value.ToString() + ")";
                }

                txtAlterColumns.Text = String.Empty;
                for (int x = 0; x < ar_tables.Length; x++)
                    txtAlterColumns.Text += str_AlterCommand[x] + "\r\n/\r\n";
            }
        }

        private void cmbColumnType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbColumnType.Text)
            {
                case "CHAR":
                    {
                        numColumnSize.Enabled = true;
                        numScale.Enabled = false;
                        numColumnSize.Maximum = 4000;
                        break;
                    }
                case "VARCHAR2":
                    {
                        numColumnSize.Enabled = true;
                        numScale.Enabled = false;
                        numColumnSize.Maximum = 4000;
                        break;
                    }
                case "NCHAR":
                    {
                        numColumnSize.Enabled = false;
                        numScale.Enabled = false;
                        numColumnSize.Maximum = 4000;
                        break;
                    }
                case "NVARCHAR2":
                    {
                        numColumnSize.Enabled = true;
                        numScale.Enabled = false;
                        numColumnSize.Maximum = 4000;
                        break;
                    }
                case "LONG":
                    {
                        numColumnSize.Enabled = false;
                        numScale.Enabled = false;
                        numColumnSize.Maximum = 4000;
                        break;
                    }
                case "FLOAT":
                    {
                        numColumnSize.Enabled = false;
                        numScale.Enabled = false;
                        numColumnSize.Maximum = 4000;
                        break;
                    }
                case "DATE":
                    {
                        numColumnSize.Enabled = false;
                        numScale.Enabled = false;
                        numColumnSize.Maximum = 4000;
                        break;
                    }
                case "RAW":
                    {
                        numColumnSize.Enabled = false;
                        numScale.Enabled = false;
                        numColumnSize.Maximum = 4000;
                        break;
                    }
                case "LONGRAW":
                    {
                        numColumnSize.Enabled = false;
                        numScale.Enabled = false;
                        numColumnSize.Maximum = 4000;
                        break;
                    }
                case "ROWID":
                    {
                        numColumnSize.Enabled = false;
                        numScale.Enabled = false;
                        numColumnSize.Maximum = 4000;
                        break;
                    }
                case "UROWID":
                    {
                        numColumnSize.Enabled = false;
                        numScale.Enabled = false;
                        numColumnSize.Maximum = 4000;
                        break;
                    }
                case "BLOB":
                    {
                        numColumnSize.Enabled = false;
                        numScale.Enabled = false;
                        numColumnSize.Maximum = 4000;
                        break;
                    }
                case "CLOB":
                    {
                        numColumnSize.Enabled = false;
                        numScale.Enabled = false;
                        numColumnSize.Maximum = 4000;
                        break;
                    }
                case "NCLOB":
                    {
                        numColumnSize.Enabled = false;
                        numScale.Enabled = false;
                        numColumnSize.Maximum = 4000;
                        break;
                    }
                case "BFILE":
                    {
                        numColumnSize.Enabled = false;
                        numScale.Enabled = false;
                        numColumnSize.Maximum = 4000;
                        break;
                    }
                case "NUMBER":
                    {
                        numColumnSize.Enabled = true;
                        numScale.Enabled = true;
                        numColumnSize.Maximum = 38;
                        break;
                    }
            }
            GenerateColumnDDL();
        }

        private void txtAlterColumns_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 65)
                txtAlterColumns.SelectAll();
        }

        private void btn_Create_PROCs_Click(object sender, EventArgs e)
        {
            if (lst_Tables.SelectedItems.Count > 0)
            {
                int iTablesEffected = lst_Tables.SelectedItems.Count;
                int iProcsEffected = 0;
                string tmp =
                    userName.Replace("\r\n/\r\n", ":");
                tmp = tmp.Substring(0, tmp.Length - 1);

                string[] alterLines = tmp.Split(':');
                foreach (string strCommandLine in alterLines)
                {
                    cmd.CommandText = strCommandLine;
                    cmd.ExecuteNonQuery();
                    iProcsEffected++;
                }
                PopulateObjectList(chTablesOnly.Checked);
                GenerateObjectList(ref tv_Objects);

                MessageBox.Show(iProcsEffected + " Procedures for " + iTablesEffected + " Tables were created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lnkRefreshColumns_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lst_Tables.SelectedItems.Count > 0)
                PopulateColumns(lst_Tables.SelectedItems[0].ToString());
        }

        private void lst_Fields_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmdString = $"SELECT tablename FROM pg_catalog.pg_tables WHERE tablename like '%{lst_Tables.SelectedItem}%' ORDER BY tablename ASC;';";
            try
            {
                txtColumnName.Text = lst_Fields.SelectedItems[0].ToString();

                DataTable dt = GenDT(cmdString);

                cmbColumnType.Text = Convert.ToString(dt.Rows[0]["DATA_TYPE"]);
                if (cmbColumnType.Text == "NUMBER")
                {
                    numColumnSize.Value = Convert.ToDecimal(dt.Rows[0]["DATA_PRECISION"]);
                    numScale.Value = Convert.ToDecimal(dt.Rows[0]["DATA_SCALE"]);
                }
                else
                {
                    numColumnSize.Value = Convert.ToDecimal(dt.Rows[0]["DATA_LENGTH"]);
                    numScale.Value = 0;
                }

                txtColumnDefault.Text = Convert.ToString(dt.Rows[0]["DATA_DEFAULT"]);
                ch_Nullable.Checked = (Convert.ToString(dt.Rows[0]["NULLABLE"]) == "Y") ? true : false;

                GenerateColumnDDL();
            }
            catch (Exception) { }
        }

        private DataTable GenDT(string strSelect)
        {
            con = new NpgsqlConnection(connectionString);
            con.Open();
            DataTable _dt = new DataTable();
            try
            {
                new NpgsqlDataAdapter(strSelect, con).Fill(_dt);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return _dt;
        }

        private void txtColumnName_TextChanged(object sender, EventArgs e)
        {
            GenerateColumnDDL();
        }

        private void numColumnSize_ValueChanged(object sender, EventArgs e)
        {
            GenerateColumnDDL();
        }

        private void numScale_ValueChanged(object sender, EventArgs e)
        {
            GenerateColumnDDL();
        }

        private void txtColumnDefault_TextChanged(object sender, EventArgs e)
        {
            GenerateColumnDDL();
        }

        private void ch_Nullable_CheckedChanged(object sender, EventArgs e)
        {
            GenerateColumnDDL();
        }

        private void GenerateObjectList(ref TreeView tv)
        {
            tv.Nodes.Clear();
            DataTable dt_TYPES, dt_TABLES;
            string schemaName, tableName;

            string selSchemas = "SELECT schema_name FROM information_schema.schemata;";
            string cmdString;
            dt_TYPES = GenDT(selSchemas);
            foreach (DataRow drTYPE in dt_TYPES.Rows)
            {
                schemaName = drTYPE["schema_name"].ToString();
                tv.Nodes.Add(schemaName, schemaName);
                //MessageBox.Show(schemaName);
                cmdString = $"SELECT table_name FROM information_schema.tables " +
                               $"WHERE table_name like '%' AND table_schema = '{schemaName}'" +
                               $"ORDER BY table_name ASC;';";

                dt_TABLES = GenDT(cmdString);
                foreach (DataRow drTABLE in dt_TABLES.Rows)
                {
                    tableName = drTABLE["table_name"].ToString();
                    if (!tableName.Contains("$"))
                        tv.Nodes[schemaName].Nodes.Add(tableName);
                }
            }
        }

        private void lnkRefreshTables_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PopulateObjectList(chTablesOnly.Checked);
            GenerateObjectList(ref tv_Objects);
        }

        private void chShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
                PopulateObjectList(((CheckBox)sender).Checked);
        }

        NpgsqlDataAdapter daLoaded;
        DataTable dtLoaded;
        private void ExecuteQuery(string _strQuery, NpgsqlConnection _con)
        {
            c = new OracleDataGridViewHelper(_con, _strQuery);

            int _r = 0;
            dtLoaded = new DataTable();
            //grdQuery.DataSource = null;

            string _q = _strQuery.Replace(";", "").Replace("/", "").TrimStart(' ').Replace("  ", " ").Trim();


            if (_q.ToUpper().StartsWith("SELECT"))
            {

                try
                {
                    daLoaded = new NpgsqlDataAdapter(_q, con);
                    _r = daLoaded.Fill(dtLoaded);
                }
                catch (Exception ex)
                {
                    tsStatus.Text = ex.Message;
                }

                //if (dtLoaded.Rows.Count > 0)
                {

                    tsStatus.Text = _r.ToString() + " rows were selected";
                    grdQuery.DataSource = dtLoaded;
                    string err = c.bindGrid(ref grdQuery, _con, _strQuery);
                    if (err.Length > 0)
                        tsStatus.Text = err;
                }
            }
            else
            {
                try
                {
                    _r = new NpgsqlCommand(_q, con).ExecuteNonQuery();

                    if (_q.ToUpper().StartsWith("DELETE"))
                        tsStatus.Text = _r.ToString() + " rows were deleted";
                    if (_q.ToUpper().StartsWith("UPDATE"))
                        tsStatus.Text = _r.ToString() + " rows were deleted";
                    if (_q.ToUpper().StartsWith("INSERT"))
                        tsStatus.Text = _r.ToString() + " rows were inserted";
                }
                catch (Exception ex) { tsStatus.Text = ex.Message; }
            }


        }

        private void txtQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F8")

                grdQuery.DataSource = null;
            if (txtQuery.SelectionLength > 0)
                if (txtQuery.SelectedText.ToUpper().Contains("SELECT"))
                    ProcessQuery(txtQuery.SelectedText);
        }

        private void ProcessQuery(string strQuery)
        {
            ExecuteQuery(strQuery, con);
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedTab == tpQuery)
            {
                txtQuery.Focus();
                txtQuery.SelectionStart = txtQuery.Text.Length;
                txtQuery.SelectionLength = 0;
                txtQuery.ScrollToCaret();
            }
        }

        private void updateGrdQuery()
        {
            //////
            txtQuery.Focus();
            c.saveGrid(ref grdQuery);
            grdQuery.DataSource = null;
            if (txtQuery.SelectionLength > 0)
                if (txtQuery.SelectedText.ToUpper().Contains("SELECT"))
                    ProcessQuery(txtQuery.SelectedText);            //////

            /*


            if (dtLoaded.GetChanges() != null)
            {
                NpgsqlCommandBuilder builder = new NpgsqlCommandBuilder(daLoaded);

                try
                {
                    tsStatus.Text = daLoaded.Update(dtLoaded.GetChanges()) + " row(s) were updated";
                    dtLoaded.AcceptChanges();
                }
                catch (Exception ex)
                {
                    tsStatus.Text = ex.Message;
                    dtLoaded.RejectChanges();
                }
            }
          */
        }

        private void tsExecute_Click(object sender, EventArgs e)
        {
            grdQuery.DataSource = null;
            if (txtQuery.SelectionLength > 0)
                if (txtQuery.SelectedText.ToUpper().Contains("SELECT"))
                    ProcessQuery(txtQuery.SelectedText);
        }

        private void tsSave_Click(object sender, EventArgs e)
        {
            updateGrdQuery();
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            c.bs.RemoveCurrent();
            //foreach (DataGridViewRow dgvr in grdQuery.SelectedRows)
            //  grdQuery.Rows.Remove(dgvr);
        }

        private void tsNew_Click(object sender, EventArgs e)
        {
            c.bs.AddNew();
            grdQuery.Focus();
            grdQuery.Select();
            //grdQuery.Rows.Add();
        }

        string strTempQuery;
        private void queryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopulateColumns(tv_Objects.SelectedNode.Text);
            txtQuery.Text = "SELECT " + strFields_with_commas.Replace(",", ", ") + " FROM " + tv_Objects.SelectedNode.Text;
            tsExecute.Image = Properties.Resources.Loading;

            tsStatus.Text = "Loading...";

            txtQuery.SelectAll();
            strTempQuery = txtQuery.SelectedText;
            ExecuteQuery(strTempQuery, con);
            //bgwQuery.RunWorkerAsync();
        }

        private void describeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtQuery.Text = "DESC " + tv_Objects.SelectedNode.Text;
            grdQuery.DataSource = null;
            if (txtQuery.SelectionLength > 0)
                if (txtQuery.SelectedText.ToUpper().Contains("SELECT"))
                    ProcessQuery(txtQuery.SelectedText);
        }

        private void tv_Objects_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ((TreeView)sender).SelectedNode = ((TreeView)sender).GetNodeAt(e.Location);
        }

        private void toUPPERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtQuery.SelectionLength > 0)
                txtQuery.Text = txtQuery.Text.Replace(txtQuery.SelectedText, txtQuery.SelectedText.ToUpper());
            else
                txtQuery.Text = txtQuery.Text.ToUpper();
        }

        private void toLowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtQuery.SelectionLength > 0)
                txtQuery.Text = txtQuery.Text.Replace(txtQuery.SelectedText, txtQuery.SelectedText.ToLower());
            else
                txtQuery.Text = txtQuery.Text.ToLower();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtQuery.SelectionLength > 0)
                txtQuery.Text = txtQuery.Text.Replace(txtQuery.SelectedText, String.Empty);
            else
                txtQuery.Text = String.Empty;
        }

        private void executeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grdQuery.DataSource = null;
            if (txtQuery.SelectionLength > 0)
                if (txtQuery.SelectedText.ToUpper().Contains("SELECT"))
                    ProcessQuery(txtQuery.SelectedText);
        }

        private void compactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtQuery.SelectionLength > 0)
                txtQuery.Text = txtQuery.Text.Replace(txtQuery.SelectedText, txtQuery.SelectedText.Replace(",\r\n", ", "));
            else
                txtQuery.Text = txtQuery.Text.Replace(",\r\n", ", ");
        }

        private void extendedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtQuery.SelectionLength > 0)
                txtQuery.Text = txtQuery.Text.Replace(txtQuery.SelectedText, txtQuery.SelectedText.Replace(", ", ",\r\n"));
            else
                txtQuery.Text = txtQuery.Text.Replace(", ", ",\r\n");

        }

        private void grdQuery_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("The data type you are trying to enter in " + ((DataGridView)sender).Columns[((DataGridView)sender).CurrentCell.ColumnIndex].HeaderText + " is invalid.", "Invalid data type", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void p_Exited(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(strTempFile.Replace(".SQL", ".HTM"));
            string strTemp = sr.ReadToEnd();
            sr.Close();

            strTemp = strTemp.Replace("SQL*Plus Report", "Objects Report - OraSwift");
            strTemp = strTemp.Replace("#cccc99", "#000000");
            strTemp = strTemp.Replace("#f7f7e7", "#eeeeee");
            strTemp = strTemp.Replace("#336699", "#ffffff");

            //Writing Script File
            StreamWriter sw;
            sw = new System.IO.StreamWriter(saveFileDialog1.FileName, false);
            sw.Write(strTemp);
            sw.Flush();
            sw.Close();


            System.Diagnostics.Process.Start(saveFileDialog1.FileName);
        }

        string strTempFile;
        private string userName;
        private string database;
        private string password;
        private bool closingConfirmed;

        private void generateObjectStructureReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = @"HTML Files|*.htm";
            saveFileDialog1.ShowDialog();

            #region Writing and running script file
            System.IO.StreamWriter sw;

            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            p.StartInfo.CreateNoWindow = true;
            p.EnableRaisingEvents = true;
            p.Exited += new System.EventHandler(p_Exited);

            p.StartInfo.FileName = @"SQLPLUS.exe";

            strTempFile = Environment.GetEnvironmentVariable("TEMP") + "\\tmp_SCRIPT.SQL";
            string strScript =
            @"CREATE OR REPLACE VIEW SCHEMA_TABLES AS
            SELECT   O.OBJECT_TYPE AS OBJECT_TYPE
            ,        C.TABLE_NAME AS TABLE_NAME
            ,        C.COLUMN_ID AS COLUMN_ID
            ,        C.COLUMN_NAME AS COLUMN_NAME
            ,        DECODE(C.NULLABLE,'N','NOT NULL','') AS NULLABLE
            ,        DECODE(C.DATA_TYPE
            ,          'BFILE'        ,'BINARY FILE LOB'
            ,          'BINARY_FLOAT' ,C.DATA_TYPE
            ,          'BINARY_DOUBLE',C.DATA_TYPE
            ,          'BLOB'         ,C.DATA_TYPE
            ,          'CLOB'         ,C.DATA_TYPE
            ,          'CHAR'         ,DECODE(NVL(C.DATA_LENGTH,0),0,C.DATA_TYPE
            ,        C.DATA_TYPE||'('||C.DATA_LENGTH||')')
            ,          'DATE'         ,C.DATA_TYPE
            ,          'FLOAT'        ,C.DATA_TYPE
            ,          'LONG RAW'     ,C.DATA_TYPE
            ,          'NCHAR'        ,DECODE(NVL(C.DATA_LENGTH,0),0,C.DATA_TYPE
            ,        C.DATA_TYPE||'('||C.DATA_LENGTH||')')
            ,          'NVARCHAR2'    ,DECODE(NVL(C.DATA_LENGTH,0),0,C.DATA_TYPE
            ,        C.DATA_TYPE||'('||C.DATA_LENGTH||')')
            ,          'NUMBER'       ,DECODE(NVL(C.DATA_PRECISION||C.DATA_SCALE,0)
            ,        0,C.DATA_TYPE
            ,        DECODE(NVL(C.DATA_SCALE,0),0
            ,        C.DATA_TYPE||'('||C.DATA_PRECISION||')'
            ,        C.DATA_TYPE||'('||C.DATA_PRECISION||','|| C.DATA_SCALE||')'))
            ,          'RAW'          ,DECODE(NVL(C.DATA_LENGTH,0),0,C.DATA_TYPE
            ,        C.DATA_TYPE||'('||C.DATA_LENGTH||')')
            ,          'VARCHAR'      ,DECODE(NVL(C.DATA_LENGTH,0),0,C.DATA_TYPE
            ,        C.DATA_TYPE||'('||C.DATA_LENGTH||')')
            ,          'VARCHAR2'     ,DECODE(NVL(C.DATA_LENGTH,0),0,C.DATA_TYPE
            ,        C.DATA_TYPE||'('||C.DATA_LENGTH||')')
            ,          'TIMESTAMP'     , C.DATA_TYPE,C.DATA_TYPE) AS DATA_TYPE
            ,        CASE WHEN C.DATA_DEFAULT IS NULL THEN 'N' ELSE 'Y' END AS DATA_DEFAULT
            FROM     USER_TAB_COLUMNS C,USER_OBJECTS O
            WHERE    O.OBJECT_NAME = C.TABLE_NAME
            ORDER BY C.TABLE_NAME, C.COLUMN_ID
            /
            SET FEED OFF MARKUP HTML ON SPOOL ON
            /
            SPOOL '" + strTempFile.Replace(".SQL", ".HTM") + @"'
            /
            SELECT * FROM SCHEMA_TABLES
            /
            SPOOL OFF
            /
            SET MARKUP HTML OFF SPOOL OFF
            /
            EXIT
            /
            ";



            //Writing Script File
            sw = new System.IO.StreamWriter(strTempFile, false);
            sw.Write(strScript);
            sw.Flush();
            sw.Close();

            p.StartInfo.Arguments = userName + @"/" + password + ((database.Length) > 0 ? @"@" + database : String.Empty) + @" @""" + strTempFile + @"""";
            p.Start();
            #endregion
        }


        private string PopulateObjectsDLL(string strObjectType, string strUser)
        {
            cmd = new NpgsqlCommand(
            @"SELECT DBMS_METADATA.GET_DDL('" + strObjectType + "',u.table_name,'" + strUser + @"')
            FROM USER_TABLES u", con);

            string strTemp = String.Empty;

            dataReader = null;
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
                strTemp += dataReader.GetString(0) + "\r\n";

            strTemp = strTemp.Replace("  ", "").Replace("\t", "\r\n");
            return strTemp;
        }
        private void exportUserObjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = @"SQL Files|*.sql";
            saveFileDialog1.ShowDialog();

            #region Writing and running script file
            System.IO.StreamWriter sw;
            string CR = "\r\n";


            string strScript = PopulateObjectsDLL("TABLE", userName);
            strScript = "-- ### Created by OraSwift ### --" + CR + CR +
            strScript.Replace("CREATE TABLE", CR + "/" + CR + "CREATE TABLE");
            //Writing Script File
            sw = new System.IO.StreamWriter(saveFileDialog1.FileName, false);
            sw.Write(strScript);
            sw.Flush();
            sw.Close();

            #endregion        
        }

        //About _About;
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
               try
               {
                   _About.Show();
                   _About.Activate();
               }
               catch (Exception)
               {
                   _About = new About();
                   _About.Show();
                   _About.Activate();
               }*/
        }
        private void tv_Objects_KeyDown(object sender, KeyEventArgs e)
        {
            if (tv_Objects.SelectedNode != null)
                if (tv_Objects.SelectedNode.Level == 1)
                    if (e.KeyCode == Keys.Enter)
                    {
                        PopulateColumns(tv_Objects.SelectedNode.Text);
                        txtQuery.Text = "SELECT " + strFields_with_commas.Replace(",", ", ") + " FROM " + tv_Objects.SelectedNode.Text;

                        grdQuery.DataSource = null;
                        if (txtQuery.SelectionLength > 0)
                            if (txtQuery.SelectedText.ToUpper().Contains("SELECT"))
                                ProcessQuery(txtQuery.SelectedText);
                    }
        }

        private void tv_Objects_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void txtTableFilter_TextChanged(object sender, EventArgs e)
        {
            GenerateObjectList(ref tv_Objects);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateObjectList(chTablesOnly.Checked);
            GenerateObjectList(ref tv_Objects);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closingConfirmed)
            {
                Application.Exit();
                return;
            }
            else
                e.Cancel = true;

            var dr = MessageBox.Show("You're about to be disconnected. Are you sure you want to continue?"
                , "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                e.Cancel = false;
                closingConfirmed = true;
                this.Close();
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void registerOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://www.qsoftonline.com");
        }

        private void bgwQuery_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

            ProcessQuery(strTempQuery);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bgwQuery.CancelAsync();
            bgwQuery.Dispose();

            tsExecute.Image = Properties.Resources.Q;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
        }





    }
}

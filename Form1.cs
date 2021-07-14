using Npgsql;
using QSoft;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            lstObjects.Nodes.Clear();


            while (dataReader.Read())
            {
                strTemp = dataReader.GetString(0);
                if (!strTemp.Contains("$"))
                    lstObjects.Nodes.Add(strTemp);
            }

            strTemp = String.Empty;

            string strObjects;
            if (bTablesOnly)
                strObjects = " Tables ";
            else
                strObjects = " Objects ";





            lbl_tables_count.Text = lstObjects.Nodes.Count + strObjects + "were found.";

            //dataReader.Close();
        }



        bool b_Multiple;


        private string GetColumnsString(string strTableName)
        {
            con = new NpgsqlConnection(connectionString);
            con.Open();
            try
            {
                cmd = new NpgsqlCommand($"SELECT column_name FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{strTableName}';", con);
                dataReader = null;

                strTemp = String.Empty;
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                    strTemp += dataReader.GetString(0) + "\",\"";

                if (strTemp.Length > 0)
                    strFields_with_commas = strTemp.Substring(0, strTemp.Length - 2);
                else
                    strFields_with_commas = strTemp;

                return $"\"{strFields_with_commas}";//.Split(',');
            }
            catch (Exception) { return String.Empty; }

        }
        private void PopulateColumns(string strTableName)
        {

            con = new NpgsqlConnection(connectionString);
            con.Open();
            try
            {

                lst_Fields.Items.Clear();
                if (lstObjects.SelectedNode != null)
                {
                    lst_Fields.Enabled = true;

                    #region Retrieving Columns
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



        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = @"SQL Files|*.sql";
            saveFileDialog1.FileName = userName + "_Query.sql";
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
@ECHO " + @" Query file created successfully!
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

                    DialogResult dr = MessageBox.Show("Are you sure you want to drop the column(s):\r\n" + Cols + "\r\nFrom " + lstObjects.SelectedNode.Text + "?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        foreach (string c in Cols.Trim().Split(','))
                        {
                            cmd.CommandText = @"ALTER TABLE " + lstObjects.SelectedNode.Text + " DROP COLUMN " + c;
                            cmd.ExecuteNonQuery();
                        }
                        PopulateColumns(lstObjects.SelectedNode.Text);
                    }
                }
                else
                    MessageBox.Show("No columns were selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception) { }
        }

        string[] str_AlterCommand;
        private DataTable dtSchemas;




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

        private void GenerateObjectList(ref TreeView tv)
        {

            tv.Nodes.Clear();


            string tableName;
            string selSchemas = "SELECT schema_name FROM information_schema.schemata;";
            string cmdString = String.Empty;


            if (dtSchemas == null)
                dtSchemas = GenDT(selSchemas);

            foreach (DataRow drTYPE in dtSchemas.Rows)
            {
                string schemaName = drTYPE["schema_name"].ToString();
                tv.Nodes.Add(schemaName, schemaName);


                //if (dtTables == null && !tvLoaded)
                {
                    cmdString = $"SELECT table_name FROM information_schema.tables " +
                                $"WHERE table_name like '%' AND table_schema = '{schemaName}'" +
                                $"ORDER BY table_name ASC;';";
                    dtTables = GenDT(cmdString);
                }

                foreach (DataRow drTABLE in dtTables.Rows)
                {
                    tableName = drTABLE["table_name"].ToString();
                    if (tableName.ToUpper().Contains($"{txtTableFilter.Text.ToUpper()}") || txtTableFilter.Text.Length == 0)
                    {
                        if (tv.Nodes[schemaName] == null)
                            tv.Nodes.Add(schemaName, schemaName);

                        tv.Nodes[schemaName].Nodes.Add(tableName);
                    }
                }
            }
            tvLoaded = true;
        }

        private void chShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
                PopulateObjectList(((CheckBox)sender).Checked);
        }

        NpgsqlDataAdapter daLoaded;
        DataTable dtLoaded;
        private void ExecuteQuery(string _strQuery)
        {





            con = new NpgsqlConnection(connectionString);
            con.Open();

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
                    Debug.Print(ex.Message);
                    tsStatus.Text = ex.Message;
                }

                //if (dtLoaded.Rows.Count > 0)
                {

                    tsStatus.Text = _r.ToString() + " rows were selected";
                    grdQuery.DataSource = dtLoaded;
                    /*                    string err = c.bindGrid(ref grdQuery, con, _strQuery);
                                        if (err.Length > 0)
                                            tsStatus.Text = err;*/
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

        private void ProcessQuery(string strQuery)
        {
            ExecuteQuery(strQuery);
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (tabControl2.SelectedTab == tpQuery)
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
            ExecuteSelect();
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
            tsExecute.Image = Properties.Resources.Loading;

            string columnsWithCommas = GetColumnsString(lstObjects.SelectedNode.Text);
            //PopulateColumns(tv_Objects.SelectedNode.Text);
            var tbl = lstObjects.SelectedNode.Text;
            var schema = lstObjects.SelectedNode.Parent?.Text;
            var strFields_with_commas = GetColumnsString(tbl);

            txtQuery.Text = $"SELECT {strFields_with_commas.Replace(",", ", ")} FROM {schema}.\"{ tbl}\" LIMIT 100";


            tsStatus.Text = "Loading...";

            txtQuery.SelectAll();
            strTempQuery = txtQuery.SelectedText;
            ExecuteQuery(strTempQuery);
            //bgwQuery.RunWorkerAsync();
            tsExecute.Image = Properties.Resources.Q;
        }

        private void describeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopulateColumns(lstObjects.SelectedNode.Text);
        }

        private void tv_Objects_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ((TreeView)sender).SelectedNode = ((TreeView)sender).GetNodeAt(e.Location);
        }

        private void toUPPERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtQuery.SelectionLength > 0)
                txtQuery.SelectedText = txtQuery.SelectedText.SQLUpper();
            else
                txtQuery.Text = txtQuery.Text.SQLUpper();
        }

        private void toLowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtQuery.SelectionLength > 0)
                txtQuery.SelectedText = txtQuery.SelectedText.SQLLower();
            else
                txtQuery.Text = txtQuery.Text.SQLLower();
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
            ExecuteSelect();
        }

        private void ExecuteSelect()
        {
            if (txtQuery.SelectedText.Length > 0)
            {
                if (!txtQuery.SelectedText.ToUpper().Contains("SELECT"))
                {
                    tsStatus.Text = "Not A Select Statement";
                    return;
                }

            }
            else
            {
                if (!txtQuery.Text.ToUpper().Contains("SELECT"))
                {
                    tsStatus.Text = "Not A Select Statement";
                    return;
                }
            }



            grdQuery.DataSource = null;


            if (txtQuery.SelectionLength > 0)
                ProcessQuery(txtQuery.SelectedText);
            else
                ProcessQuery(txtQuery.Text);
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
            string tmp;
            if (txtQuery.SelectionLength > 0)
            {
                tmp = txtQuery.SelectedText;
                txtQuery.Text = txtQuery.Text.Replace(txtQuery.SelectedText, txtQuery.SelectedText.Replace(", ", ",\r\n"));

                /*                txtQuery.Text = txtQuery.Text.Replace(txtQuery.SelectedText, txtQuery.SelectedText.Replace("FROM", "\r\nFROM"));
                                txtQuery.Text = txtQuery.Text.Replace(txtQuery.SelectedText, txtQuery.SelectedText.Replace("WHERE", "\r\nWHERE"));
                                txtQuery.Text = txtQuery.Text.Replace(txtQuery.SelectedText, txtQuery.SelectedText.Replace("JOIN", "\r\nJOIN"));
                                txtQuery.Text = txtQuery.Text.Replace(txtQuery.SelectedText, txtQuery.SelectedText.Replace("GROUP BY", "\r\nGROUP BY"));
                                txtQuery.Text = txtQuery.Text.Replace(txtQuery.SelectedText, txtQuery.SelectedText.Replace("ORDER BY", "\r\nORDER BY"));
                                txtQuery.Text = txtQuery.Text.Replace(txtQuery.SelectedText, txtQuery.SelectedText.Replace("LIMIT", "\r\nLIMIT"));*/
            }
            else
            {
                tmp = txtQuery.Text;
                txtQuery.Text = txtQuery.Text.Replace(txtQuery.Text, txtQuery.Text.Replace(", ", ",\r\n"));
                /*               txtQuery.Text = txtQuery.Text.Replace(txtQuery.Text, txtQuery.Text.ToUpper().Replace("FROM", "\r\nFROM"));
                               txtQuery.Text = txtQuery.Text.Replace(txtQuery.Text, txtQuery.Text.ToUpper().Replace("WHERE", "\r\nWHERE"));
                               txtQuery.Text = txtQuery.Text.Replace(txtQuery.Text, txtQuery.Text.ToUpper().Replace("JOIN", "\r\nJOIN"));
                               txtQuery.Text = txtQuery.Text.Replace(txtQuery.Text, txtQuery.Text.ToUpper().Replace("GROUP BY", "\r\nGROUP BY"));
                               txtQuery.Text = txtQuery.Text.Replace(txtQuery.Text, txtQuery.Text.ToUpper().Replace("ORDER BY", "\r\nORDER BY"));
                               txtQuery.Text = txtQuery.Text.Replace(txtQuery.Text, txtQuery.Text.ToUpper().Replace("LIMIT", "\r\nLIMIT"));*/
            }

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
        private DataTable dtTables;
        private string schemaName;
        private bool tvLoaded;

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
            if (lstObjects.SelectedNode != null)
                if (lstObjects.SelectedNode.Level == 1)
                    if (e.KeyCode == Keys.Enter)
                    {
                        PopulateColumns(lstObjects.SelectedNode.Text);
                        txtQuery.Text = "SELECT " + strFields_with_commas.Replace(",", ", ") + " FROM " + lstObjects.SelectedNode.Text;

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
            GenerateObjectList(ref lstObjects);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateObjectList(chTablesOnly.Checked);
            GenerateObjectList(ref lstObjects);
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


            var dr = MessageBox.Show("You're about to be Disconnected.\nAre you sure you want to continue?",
                                     "Closing...",
                                     MessageBoxButtons.YesNoCancel,
                                     MessageBoxIcon.Warning,
                                     MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                e.Cancel = false;
                closingConfirmed = true;
                this.Close();
            }

        }

        private void txtTableFilter_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                GenerateObjectList(ref lstObjects);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GenerateObjectList(ref lstObjects);
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
public static class StringExtension
{
    public static string SQLUpper(this string s)
    {
        return new StringBuilder(s)
      .Replace("select", "SELECT")
      .Replace("distinct", "DISTINCT")
      .Replace("from", "FROM")
      .Replace("join", "JOIN")
      .Replace("where", "WHERE")
      .Replace("group by", "GROUP BY")
      .Replace("order by", "ORDER BY")
      .Replace("limit", "LIMIT")
      .ToString();
    }

    public static string SQLLower(this string s)
    {
        return new StringBuilder(s)
      .Replace("SELECT", "select")
      .Replace("DISTINCT", "distinct")
      .Replace("FROM", "from")
      .Replace("JOIN", "join")
      .Replace("WHERE", "where")
      .Replace("GROUP BY", "group by")
      .Replace("ORDER BY", "order by")
      .Replace("LIMIT", "limit")
      .ToString();
    }

}

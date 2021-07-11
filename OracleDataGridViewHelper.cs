using Npgsql;
using System;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace QSoft
{
    class OracleDataGridViewHelper
    {
        NpgsqlCommand cmd;
        NpgsqlDataAdapter adap;
        public DataTable dt;
        public BindingSource bs;

        public OracleDataGridViewHelper()
        { }

        public OracleDataGridViewHelper(NpgsqlConnection con, string strSelect)
        {
            try
            {
                CreateCommand(con, strSelect);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void CreateCommand(NpgsqlConnection con, string strSelect)
        {
            try
            {
            if (con.State != ConnectionState.Open)
                con.Open();

            cmd = new NpgsqlCommand(strSelect, con);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        public string bindGrid(ref DataGridView grd, NpgsqlConnection con, string strSelect)
        {
            string err = String.Empty;
            try
            {
            CreateCommand(con, strSelect);

            adap = new NpgsqlDataAdapter(cmd);

            dt = new DataTable();
            adap.Fill(dt);

            grd.AutoGenerateColumns = true;

            //////////////
            bs = new BindingSource(dt, dt.TableName);
            grd.DataSource = bs;
            }
            catch (Exception ex)
            { err = ex.Message; }
            return err;
        }

        
        public void saveGrid(ref DataGridView grd)
        {
            try
            {
                //cmdBldr = new NpgsqlCommandBuilder(adap);
                bs = (BindingSource)grd.DataSource;

                dt = (DataTable)bs.DataSource;

                adap.Update(dt);
                dt.AcceptChanges();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}

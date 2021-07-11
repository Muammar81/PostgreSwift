using Npgsql;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PROC_GEN
{
    public partial class Authentication : Form
    {
        private string connectionString;

        public Authentication()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            bool conStatus = false;
            btn_connect.Text = "Connecting...";
            btn_connect.Enabled = false;
            EnableControls((ControlCollection)this.Controls, false);

            conStatus = DBConnect();


            if (conStatus)
            {
                new Form1(connectionString, this).Show();
                this.Hide();
                //PopulateObjectList(chTablesOnly.Checked);
                //GenerateObjectList(ref tv_Objects);

            }
            else
            {
                foreach (Control c in this.Controls)
                    c.Enabled = true;
                btn_connect.Text = "&Connect";
            }
        }

        private void EnableControls(ControlCollection ctrls, bool status)
        {
            foreach (Control c in ctrls)
            {
                if (c.Controls.Count > 0)
                {
                    foreach (Control cc in c.Controls)
                        cc.Enabled = status;
                }
                c.Enabled = status;
            }
        }

        private bool DBConnect()
        {

            connectionString =
                $"Server={txtServer.Text}; " +
                $"Port={numPort.Value}; " +
                $"Userid={txtUsername.Text}; " +
                $"Password={txtPassword.Text}; " +
                $"Database={txtDatabase.Text}; " +
                $"sslmode={(ch_SSL.Checked ? "Require" : "Prefer")}; " +
                $"Trust Server Certificate=true; " +
                $"Pooling=true; Minimum Pool Size=10;Maximum Pool Size=100;";

            NpgsqlConnection con = new NpgsqlConnection(connectionString);



            try
            {
                con.Open();
                return true;
            }
            catch (Exception e)
            {

                btn_connect.Text = "&Connect";
                DialogResult dr = MessageBox.Show("Error connecting to " + txtDatabase.Text + "\nPlease make sure you provided the correct details.", "Connection Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (dr == DialogResult.Retry)
                    DBConnect();
                else
                {
                    EnableControls((ControlCollection)this.Controls, true);
                    btn_connect.Text = "&Connect";

                }
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PROC_GEN
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.Show();
        }

        private void lnk_free_stuff_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://www.qsoftonline.com/free_stuff");
            
        }

        private void lnk_website_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://www.qsoftonline.com");
        }

        private void About_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyCode.ToString());
        }
    }
}
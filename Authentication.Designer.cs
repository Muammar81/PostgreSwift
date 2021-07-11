
namespace PROC_GEN
{
    partial class Authentication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentication));
            this.grp_Auth = new System.Windows.Forms.GroupBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.ch_SSL = new System.Windows.Forms.CheckBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.grp_Auth.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_Auth
            // 
            this.grp_Auth.Controls.Add(this.txtUsername);
            this.grp_Auth.Controls.Add(this.label3);
            this.grp_Auth.Controls.Add(this.txtPassword);
            this.grp_Auth.Controls.Add(this.label4);
            this.grp_Auth.Location = new System.Drawing.Point(12, 22);
            this.grp_Auth.Name = "grp_Auth";
            this.grp_Auth.Size = new System.Drawing.Size(325, 80);
            this.grp_Auth.TabIndex = 23;
            this.grp_Auth.TabStop = false;
            this.grp_Auth.Text = "Credentials";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numPort);
            this.groupBox1.Controls.Add(this.ch_SSL);
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDatabase);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_connect);
            this.groupBox1.Location = new System.Drawing.Point(12, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 143);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database";
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(256, 52);
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
            this.numPort.TabIndex = 39;
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
            this.ch_SSL.Location = new System.Drawing.Point(20, 111);
            this.ch_SSL.Name = "ch_SSL";
            this.ch_SSL.Size = new System.Drawing.Size(86, 17);
            this.ch_SSL.TabIndex = 38;
            this.ch_SSL.Text = "Require SSL";
            this.ch_SSL.UseVisualStyleBackColor = true;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(79, 52);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(136, 20);
            this.txtServer.TabIndex = 37;
            this.txtServer.Text = "arabella.palantircloud.com";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Server:";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(79, 27);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(231, 20);
            this.txtDatabase.TabIndex = 33;
            this.txtDatabase.Text = "palantir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Host:";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(20, 78);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(290, 23);
            this.btn_connect.TabIndex = 34;
            this.btn_connect.Text = "&Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 263);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grp_Auth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication";
            this.TopMost = true;
            this.grp_Auth.ResumeLayout(false);
            this.grp_Auth.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Auth;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.CheckBox ch_SSL;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_connect;
    }
}
namespace PROC_GEN
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.lnk_free_stuff = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lnk_website = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lnk_free_stuff
            // 
            this.lnk_free_stuff.AutoSize = true;
            this.lnk_free_stuff.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_free_stuff.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnk_free_stuff.LinkColor = System.Drawing.Color.SteelBlue;
            this.lnk_free_stuff.Location = new System.Drawing.Point(32, 104);
            this.lnk_free_stuff.Name = "lnk_free_stuff";
            this.lnk_free_stuff.Size = new System.Drawing.Size(226, 19);
            this.lnk_free_stuff.TabIndex = 1;
            this.lnk_free_stuff.TabStop = true;
            this.lnk_free_stuff.Text = "Download FREE stuff from QSoft";
            this.lnk_free_stuff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnk_free_stuff.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_free_stuff_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROC_GEN.Properties.Resources.little_Gear;
            this.pictureBox1.Location = new System.Drawing.Point(223, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "OraSwift\r\nVer: 1.0\r\nBy";
            // 
            // lnk_website
            // 
            this.lnk_website.AutoSize = true;
            this.lnk_website.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.lnk_website.LinkColor = System.Drawing.Color.Gray;
            this.lnk_website.Location = new System.Drawing.Point(33, 56);
            this.lnk_website.Name = "lnk_website";
            this.lnk_website.Size = new System.Drawing.Size(43, 16);
            this.lnk_website.TabIndex = 4;
            this.lnk_website.TabStop = true;
            this.lnk_website.Text = "QSoft";
            this.lnk_website.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_website_LinkClicked);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(298, 132);
            this.Controls.Add(this.lnk_website);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lnk_free_stuff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " About";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.About_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnk_free_stuff;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnk_website;
    }
}
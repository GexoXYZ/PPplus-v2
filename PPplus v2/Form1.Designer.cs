namespace PPplus_v2
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.radio_ctb = new MetroFramework.Controls.MetroRadioButton();
            this.radio_mania = new MetroFramework.Controls.MetroRadioButton();
            this.radio_taiko = new MetroFramework.Controls.MetroRadioButton();
            this.radio_std = new MetroFramework.Controls.MetroRadioButton();
            this.btn_Connect = new MetroFramework.Controls.MetroButton();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lbl_username = new MetroFramework.Controls.MetroLabel();
            this.txt_IRCpass = new MetroFramework.Controls.MetroTextBox();
            this.txt_APIkey = new MetroFramework.Controls.MetroTextBox();
            this.txt_Username = new MetroFramework.Controls.MetroTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(322, 258);
            this.metroTabControl1.TabIndex = 0;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.radio_ctb);
            this.metroTabPage1.Controls.Add(this.radio_mania);
            this.metroTabPage1.Controls.Add(this.radio_taiko);
            this.metroTabPage1.Controls.Add(this.radio_std);
            this.metroTabPage1.Controls.Add(this.btn_Connect);
            this.metroTabPage1.Controls.Add(this.metroLink2);
            this.metroTabPage1.Controls.Add(this.metroLink1);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.lbl_username);
            this.metroTabPage1.Controls.Add(this.txt_IRCpass);
            this.metroTabPage1.Controls.Add(this.txt_APIkey);
            this.metroTabPage1.Controls.Add(this.txt_Username);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(314, 219);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Home";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroLabel1.Location = new System.Drawing.Point(226, 204);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "gexo.xyz";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // radio_ctb
            // 
            this.radio_ctb.AutoSize = true;
            this.radio_ctb.Location = new System.Drawing.Point(231, 169);
            this.radio_ctb.Name = "radio_ctb";
            this.radio_ctb.Size = new System.Drawing.Size(42, 15);
            this.radio_ctb.TabIndex = 2;
            this.radio_ctb.TabStop = true;
            this.radio_ctb.Text = "CtB";
            this.radio_ctb.UseVisualStyleBackColor = true;
            // 
            // radio_mania
            // 
            this.radio_mania.AutoSize = true;
            this.radio_mania.Location = new System.Drawing.Point(72, 169);
            this.radio_mania.Name = "radio_mania";
            this.radio_mania.Size = new System.Drawing.Size(78, 15);
            this.radio_mania.TabIndex = 3;
            this.radio_mania.TabStop = true;
            this.radio_mania.Text = "osu!mania";
            this.radio_mania.UseVisualStyleBackColor = true;
            // 
            // radio_taiko
            // 
            this.radio_taiko.AutoSize = true;
            this.radio_taiko.Location = new System.Drawing.Point(161, 168);
            this.radio_taiko.Name = "radio_taiko";
            this.radio_taiko.Size = new System.Drawing.Size(51, 15);
            this.radio_taiko.TabIndex = 4;
            this.radio_taiko.TabStop = true;
            this.radio_taiko.Text = "Taiko";
            this.radio_taiko.UseVisualStyleBackColor = true;
            // 
            // radio_std
            // 
            this.radio_std.AutoSize = true;
            this.radio_std.Location = new System.Drawing.Point(3, 169);
            this.radio_std.Name = "radio_std";
            this.radio_std.Size = new System.Drawing.Size(61, 15);
            this.radio_std.TabIndex = 1;
            this.radio_std.TabStop = true;
            this.radio_std.Text = "osu!std";
            this.radio_std.UseVisualStyleBackColor = true;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(125, 138);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 4;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // metroLink2
            // 
            this.metroLink2.Location = new System.Drawing.Point(90, 95);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(75, 23);
            this.metroLink2.TabIndex = 9;
            this.metroLink2.Text = "Get Here!";
            this.metroLink2.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(90, 57);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 23);
            this.metroLink1.TabIndex = 8;
            this.metroLink1.Text = "Get here!";
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 95);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "API Key:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 57);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(90, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "IRC Password:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(3, 19);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(71, 19);
            this.lbl_username.TabIndex = 5;
            this.lbl_username.Text = "Username:";
            // 
            // txt_IRCpass
            // 
            this.txt_IRCpass.Location = new System.Drawing.Point(171, 58);
            this.txt_IRCpass.Name = "txt_IRCpass";
            this.txt_IRCpass.PasswordChar = '•';
            this.txt_IRCpass.Size = new System.Drawing.Size(102, 23);
            this.txt_IRCpass.TabIndex = 2;
            // 
            // txt_APIkey
            // 
            this.txt_APIkey.Location = new System.Drawing.Point(171, 95);
            this.txt_APIkey.Name = "txt_APIkey";
            this.txt_APIkey.PasswordChar = '•';
            this.txt_APIkey.Size = new System.Drawing.Size(102, 23);
            this.txt_APIkey.TabIndex = 3;
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(171, 19);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(102, 23);
            this.txt_Username.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "PP+ is now minimized to tray.";
            this.notifyIcon1.BalloonTipTitle = "PP+";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 323);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PP+";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize_1);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lbl_username;
        private MetroFramework.Controls.MetroTextBox txt_IRCpass;
        private MetroFramework.Controls.MetroTextBox txt_APIkey;
        private MetroFramework.Controls.MetroTextBox txt_Username;
        private MetroFramework.Controls.MetroButton btn_Connect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton radio_ctb;
        private MetroFramework.Controls.MetroRadioButton radio_mania;
        private MetroFramework.Controls.MetroRadioButton radio_taiko;
        private MetroFramework.Controls.MetroRadioButton radio_std;
        private System.Windows.Forms.Timer timer2;
    }
}


namespace QuarksLibrary
{
    partial class Preferences
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
            this.setupTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.savePreferences = new System.Windows.Forms.Button();
            this.discardPreferences = new System.Windows.Forms.Button();
            this.mailerTest = new System.Windows.Forms.Button();
            this.proxyport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.useProxy = new System.Windows.Forms.CheckBox();
            this.smtpPort = new System.Windows.Forms.TextBox();
            this.proxy = new System.Windows.Forms.TextBox();
            this.smtpClient = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.setupTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // setupTabs
            // 
            this.setupTabs.Controls.Add(this.tabPage1);
            this.setupTabs.Controls.Add(this.tabPage2);
            this.setupTabs.Location = new System.Drawing.Point(12, 12);
            this.setupTabs.Name = "setupTabs";
            this.setupTabs.SelectedIndex = 0;
            this.setupTabs.Size = new System.Drawing.Size(358, 353);
            this.setupTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mailerTest);
            this.tabPage1.Controls.Add(this.proxyport);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.useProxy);
            this.tabPage1.Controls.Add(this.smtpPort);
            this.tabPage1.Controls.Add(this.proxy);
            this.tabPage1.Controls.Add(this.smtpClient);
            this.tabPage1.Controls.Add(this.password);
            this.tabPage1.Controls.Add(this.username);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(350, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mailer login";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(350, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Database Connections";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // savePreferences
            // 
            this.savePreferences.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.savePreferences.Location = new System.Drawing.Point(291, 371);
            this.savePreferences.Name = "savePreferences";
            this.savePreferences.Size = new System.Drawing.Size(75, 23);
            this.savePreferences.TabIndex = 0;
            this.savePreferences.Text = "Save";
            this.savePreferences.UseVisualStyleBackColor = true;
            // 
            // discardPreferences
            // 
            this.discardPreferences.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.discardPreferences.Location = new System.Drawing.Point(196, 371);
            this.discardPreferences.Name = "discardPreferences";
            this.discardPreferences.Size = new System.Drawing.Size(75, 23);
            this.discardPreferences.TabIndex = 1;
            this.discardPreferences.Text = "Discard";
            this.discardPreferences.UseVisualStyleBackColor = true;
            // 
            // mailerTest
            // 
            this.mailerTest.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mailerTest.Location = new System.Drawing.Point(269, 300);
            this.mailerTest.Name = "mailerTest";
            this.mailerTest.Size = new System.Drawing.Size(75, 21);
            this.mailerTest.TabIndex = 28;
            this.mailerTest.Text = "Test";
            this.mailerTest.UseVisualStyleBackColor = true;
            this.mailerTest.Click += new System.EventHandler(this.mailerTest_Click);
            // 
            // proxyport
            // 
            this.proxyport.Location = new System.Drawing.Point(82, 225);
            this.proxyport.Name = "proxyport";
            this.proxyport.Size = new System.Drawing.Size(262, 20);
            this.proxyport.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Port";
            // 
            // useProxy
            // 
            this.useProxy.AutoSize = true;
            this.useProxy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.useProxy.Location = new System.Drawing.Point(24, 168);
            this.useProxy.Name = "useProxy";
            this.useProxy.Size = new System.Drawing.Size(79, 18);
            this.useProxy.TabIndex = 25;
            this.useProxy.Text = "Use proxy";
            this.useProxy.UseVisualStyleBackColor = true;
            this.useProxy.CheckedChanged += new System.EventHandler(this.useProxy_CheckedChanged);
            // 
            // smtpPort
            // 
            this.smtpPort.Location = new System.Drawing.Point(82, 116);
            this.smtpPort.Name = "smtpPort";
            this.smtpPort.Size = new System.Drawing.Size(262, 20);
            this.smtpPort.TabIndex = 24;
            // 
            // proxy
            // 
            this.proxy.Location = new System.Drawing.Point(82, 197);
            this.proxy.Name = "proxy";
            this.proxy.Size = new System.Drawing.Size(262, 20);
            this.proxy.TabIndex = 23;
            // 
            // smtpClient
            // 
            this.smtpClient.Location = new System.Drawing.Point(82, 83);
            this.smtpClient.Name = "smtpClient";
            this.smtpClient.Size = new System.Drawing.Size(262, 20);
            this.smtpClient.TabIndex = 22;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(82, 50);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(262, 20);
            this.password.TabIndex = 21;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(82, 17);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(262, 20);
            this.username.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Proxy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "smpt Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "smtp Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Resource";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Port";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Username";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(3, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 150);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book database";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(269, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Test";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(74, 29);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(261, 20);
            this.textBox7.TabIndex = 5;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(74, 55);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(261, 20);
            this.textBox8.TabIndex = 6;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(74, 81);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(261, 20);
            this.textBox9.TabIndex = 7;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(74, 107);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(261, 20);
            this.textBox10.TabIndex = 8;
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 401);
            this.Controls.Add(this.discardPreferences);
            this.Controls.Add(this.savePreferences);
            this.Controls.Add(this.setupTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Preferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preferences";
            this.setupTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl setupTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button savePreferences;
        private System.Windows.Forms.Button discardPreferences;
        private System.Windows.Forms.Button mailerTest;
        private System.Windows.Forms.TextBox proxyport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox useProxy;
        private System.Windows.Forms.TextBox smtpPort;
        private System.Windows.Forms.TextBox proxy;
        private System.Windows.Forms.TextBox smtpClient;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}
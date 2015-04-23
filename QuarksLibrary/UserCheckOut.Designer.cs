namespace QuarksLibrary
{
    partial class UserCheckOut
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
            this.searchBar = new System.Windows.Forms.TextBox();
            this.searchResutGrid = new System.Windows.Forms.DataGridView();
            this.nameSearch = new System.Windows.Forms.RadioButton();
            this.indexSearch = new System.Windows.Forms.RadioButton();
            this.bookCheckout = new System.Windows.Forms.Button();
            this.userDetails = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.subName = new System.Windows.Forms.Label();
            this.subNIC = new System.Windows.Forms.Label();
            this.subAdd = new System.Windows.Forms.Label();
            this.subTel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.subEmail = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.ISBNlabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.returnBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchResutGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(113, 12);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(492, 20);
            this.searchBar.TabIndex = 0;
            this.searchBar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // searchResutGrid
            // 
            this.searchResutGrid.AllowUserToAddRows = false;
            this.searchResutGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.searchResutGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResutGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.searchResutGrid.Location = new System.Drawing.Point(12, 96);
            this.searchResutGrid.MultiSelect = false;
            this.searchResutGrid.Name = "searchResutGrid";
            this.searchResutGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchResutGrid.Size = new System.Drawing.Size(593, 99);
            this.searchResutGrid.TabIndex = 1;
            this.searchResutGrid.Click += new System.EventHandler(this.searchResutGrid_Click);
            // 
            // nameSearch
            // 
            this.nameSearch.AutoSize = true;
            this.nameSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nameSearch.Location = new System.Drawing.Point(12, 70);
            this.nameSearch.Name = "nameSearch";
            this.nameSearch.Size = new System.Drawing.Size(108, 18);
            this.nameSearch.TabIndex = 2;
            this.nameSearch.TabStop = true;
            this.nameSearch.Text = "Search by name";
            this.nameSearch.UseVisualStyleBackColor = true;
            // 
            // indexSearch
            // 
            this.indexSearch.AutoSize = true;
            this.indexSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.indexSearch.Location = new System.Drawing.Point(12, 41);
            this.indexSearch.Name = "indexSearch";
            this.indexSearch.Size = new System.Drawing.Size(100, 18);
            this.indexSearch.TabIndex = 3;
            this.indexSearch.TabStop = true;
            this.indexSearch.Text = "Search by NIC";
            this.indexSearch.UseVisualStyleBackColor = true;
            // 
            // bookCheckout
            // 
            this.bookCheckout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bookCheckout.Location = new System.Drawing.Point(530, 482);
            this.bookCheckout.Name = "bookCheckout";
            this.bookCheckout.Size = new System.Drawing.Size(75, 23);
            this.bookCheckout.TabIndex = 5;
            this.bookCheckout.Text = "Checkout";
            this.bookCheckout.UseVisualStyleBackColor = true;
            this.bookCheckout.Click += new System.EventHandler(this.bookCheckout_Click);
            // 
            // userDetails
            // 
            this.userDetails.AutoSize = true;
            this.userDetails.Location = new System.Drawing.Point(12, 15);
            this.userDetails.Name = "userDetails";
            this.userDetails.Size = new System.Drawing.Size(62, 13);
            this.userDetails.TabIndex = 6;
            this.userDetails.Text = "User details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "T.P.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "NIC";
            // 
            // subName
            // 
            this.subName.AutoSize = true;
            this.subName.Location = new System.Drawing.Point(104, 27);
            this.subName.Name = "subName";
            this.subName.Size = new System.Drawing.Size(116, 13);
            this.subName.TabIndex = 12;
            this.subName.Text = "Name of the subscriber";
            // 
            // subNIC
            // 
            this.subNIC.AutoSize = true;
            this.subNIC.Location = new System.Drawing.Point(104, 57);
            this.subNIC.Name = "subNIC";
            this.subNIC.Size = new System.Drawing.Size(146, 13);
            this.subNIC.TabIndex = 13;
            this.subNIC.Text = "National Identity Card number";
            // 
            // subAdd
            // 
            this.subAdd.AutoSize = true;
            this.subAdd.Location = new System.Drawing.Point(104, 87);
            this.subAdd.Name = "subAdd";
            this.subAdd.Size = new System.Drawing.Size(99, 13);
            this.subAdd.TabIndex = 14;
            this.subAdd.Text = "Residential address";
            // 
            // subTel
            // 
            this.subTel.AutoSize = true;
            this.subTel.Location = new System.Drawing.Point(104, 117);
            this.subTel.Name = "subTel";
            this.subTel.Size = new System.Drawing.Size(96, 13);
            this.subTel.TabIndex = 15;
            this.subTel.Text = "Telephone number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "E-mail address";
            // 
            // subEmail
            // 
            this.subEmail.AutoSize = true;
            this.subEmail.Location = new System.Drawing.Point(104, 147);
            this.subEmail.Name = "subEmail";
            this.subEmail.Size = new System.Drawing.Size(75, 13);
            this.subEmail.TabIndex = 17;
            this.subEmail.Text = "E-mail address";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.subEmail);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.subTel);
            this.groupBox1.Controls.Add(this.subAdd);
            this.groupBox1.Controls.Add(this.subNIC);
            this.groupBox1.Controls.Add(this.subName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 164);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dueDateLabel);
            this.groupBox2.Controls.Add(this.ISBNlabel);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.authorLabel);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.titleLabel);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(6, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 130);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book details";
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Location = new System.Drawing.Point(104, 103);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(51, 13);
            this.dueDateLabel.TabIndex = 7;
            this.dueDateLabel.Text = "Due date";
            // 
            // ISBNlabel
            // 
            this.ISBNlabel.AutoSize = true;
            this.ISBNlabel.Location = new System.Drawing.Point(104, 77);
            this.ISBNlabel.Name = "ISBNlabel";
            this.ISBNlabel.Size = new System.Drawing.Size(70, 13);
            this.ISBNlabel.TabIndex = 6;
            this.ISBNlabel.Text = "ISBN number";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 103);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Due date";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "ISBN";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(104, 51);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(38, 13);
            this.authorLabel.TabIndex = 3;
            this.authorLabel.Text = "Author";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Author";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(104, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(51, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Book title";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Book title";
            // 
            // returnBook
            // 
            this.returnBook.Location = new System.Drawing.Point(530, 447);
            this.returnBook.Name = "returnBook";
            this.returnBook.Size = new System.Drawing.Size(75, 23);
            this.returnBook.TabIndex = 20;
            this.returnBook.Text = "Return";
            this.returnBook.UseVisualStyleBackColor = true;
            this.returnBook.Click += new System.EventHandler(this.returnBook_Click);
            // 
            // UserCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 514);
            this.Controls.Add(this.returnBook);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.userDetails);
            this.Controls.Add(this.bookCheckout);
            this.Controls.Add(this.indexSearch);
            this.Controls.Add(this.nameSearch);
            this.Controls.Add(this.searchResutGrid);
            this.Controls.Add(this.searchBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "UserCheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Check Out";
            ((System.ComponentModel.ISupportInitialize)(this.searchResutGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.DataGridView searchResutGrid;
        private System.Windows.Forms.RadioButton nameSearch;
        private System.Windows.Forms.RadioButton indexSearch;
        private System.Windows.Forms.Button bookCheckout;
        private System.Windows.Forms.Label userDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label subName;
        private System.Windows.Forms.Label subNIC;
        private System.Windows.Forms.Label subAdd;
        private System.Windows.Forms.Label subTel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label subEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.Label ISBNlabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button returnBook;
    }
}
namespace QuarksLibrary
{
    partial class QuarksMain
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllSubscribersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDeleteUpdateBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRemoveSubscribersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookDetails = new System.Windows.Forms.Label();
            this.bookData = new System.Windows.Forms.DataGridView();
            this.searchFor = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.bookCategory = new System.Windows.Forms.Label();
            this.categorySelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fromText = new System.Windows.Forms.TextBox();
            this.toText = new System.Windows.Forms.TextBox();
            this.ISBNsearchRad = new System.Windows.Forms.RadioButton();
            this.AuthSearchRad = new System.Windows.Forms.RadioButton();
            this.CategorySearchRad = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.authName = new System.Windows.Forms.TextBox();
            this.bookSearchButton = new System.Windows.Forms.Button();
            this.proceedButton = new System.Windows.Forms.Button();
            this.titleSearchRad = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.checkYear = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(658, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllSubscribersToolStripMenuItem,
            this.viewAllBooksToolStripMenuItem,
            this.addDeleteUpdateBooksToolStripMenuItem,
            this.addRemoveSubscribersToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // viewAllSubscribersToolStripMenuItem
            // 
            this.viewAllSubscribersToolStripMenuItem.Name = "viewAllSubscribersToolStripMenuItem";
            this.viewAllSubscribersToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.viewAllSubscribersToolStripMenuItem.Text = "View all subscribers";
            // 
            // viewAllBooksToolStripMenuItem
            // 
            this.viewAllBooksToolStripMenuItem.Name = "viewAllBooksToolStripMenuItem";
            this.viewAllBooksToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.viewAllBooksToolStripMenuItem.Text = "View all books";
            // 
            // addDeleteUpdateBooksToolStripMenuItem
            // 
            this.addDeleteUpdateBooksToolStripMenuItem.Name = "addDeleteUpdateBooksToolStripMenuItem";
            this.addDeleteUpdateBooksToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.addDeleteUpdateBooksToolStripMenuItem.Text = "Add/Delete/Update books";
            // 
            // addRemoveSubscribersToolStripMenuItem
            // 
            this.addRemoveSubscribersToolStripMenuItem.Name = "addRemoveSubscribersToolStripMenuItem";
            this.addRemoveSubscribersToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.addRemoveSubscribersToolStripMenuItem.Text = "Add/Remove subscribers";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // bookDetails
            // 
            this.bookDetails.AutoSize = true;
            this.bookDetails.Location = new System.Drawing.Point(12, 351);
            this.bookDetails.Name = "bookDetails";
            this.bookDetails.Size = new System.Drawing.Size(65, 13);
            this.bookDetails.TabIndex = 1;
            this.bookDetails.Text = "Book details";
            // 
            // bookData
            // 
            this.bookData.AllowUserToAddRows = false;
            this.bookData.AllowUserToDeleteRows = false;
            this.bookData.AllowUserToResizeRows = false;
            this.bookData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.bookData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookData.Location = new System.Drawing.Point(12, 202);
            this.bookData.MultiSelect = false;
            this.bookData.Name = "bookData";
            this.bookData.ReadOnly = true;
            this.bookData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookData.Size = new System.Drawing.Size(634, 129);
            this.bookData.TabIndex = 2;
            // 
            // searchFor
            // 
            this.searchFor.AutoSize = true;
            this.searchFor.Location = new System.Drawing.Point(9, 34);
            this.searchFor.Name = "searchFor";
            this.searchFor.Size = new System.Drawing.Size(60, 13);
            this.searchFor.TabIndex = 3;
            this.searchFor.Text = "Title/ISBN ";
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(112, 31);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(534, 20);
            this.searchBar.TabIndex = 4;
            this.searchBar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchBar_KeyUp);
            // 
            // bookCategory
            // 
            this.bookCategory.AutoSize = true;
            this.bookCategory.Location = new System.Drawing.Point(9, 65);
            this.bookCategory.Name = "bookCategory";
            this.bookCategory.Size = new System.Drawing.Size(76, 13);
            this.bookCategory.TabIndex = 5;
            this.bookCategory.Text = "Book category";
            // 
            // categorySelect
            // 
            this.categorySelect.FormattingEnabled = true;
            this.categorySelect.Location = new System.Drawing.Point(112, 62);
            this.categorySelect.Name = "categorySelect";
            this.categorySelect.Size = new System.Drawing.Size(185, 21);
            this.categorySelect.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "From";
            // 
            // fromText
            // 
            this.fromText.Location = new System.Drawing.Point(496, 62);
            this.fromText.MaxLength = 4;
            this.fromText.Name = "fromText";
            this.fromText.Size = new System.Drawing.Size(59, 20);
            this.fromText.TabIndex = 11;
            // 
            // toText
            // 
            this.toText.Location = new System.Drawing.Point(587, 62);
            this.toText.MaxLength = 4;
            this.toText.Name = "toText";
            this.toText.Size = new System.Drawing.Size(59, 20);
            this.toText.TabIndex = 12;
            // 
            // ISBNsearchRad
            // 
            this.ISBNsearchRad.AutoSize = true;
            this.ISBNsearchRad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ISBNsearchRad.Location = new System.Drawing.Point(125, 35);
            this.ISBNsearchRad.Name = "ISBNsearchRad";
            this.ISBNsearchRad.Size = new System.Drawing.Size(91, 18);
            this.ISBNsearchRad.TabIndex = 15;
            this.ISBNsearchRad.TabStop = true;
            this.ISBNsearchRad.Text = "ISBN search";
            this.ISBNsearchRad.UseVisualStyleBackColor = true;
            // 
            // AuthSearchRad
            // 
            this.AuthSearchRad.AutoSize = true;
            this.AuthSearchRad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AuthSearchRad.Location = new System.Drawing.Point(285, 35);
            this.AuthSearchRad.Name = "AuthSearchRad";
            this.AuthSearchRad.Size = new System.Drawing.Size(62, 18);
            this.AuthSearchRad.TabIndex = 16;
            this.AuthSearchRad.TabStop = true;
            this.AuthSearchRad.Text = "Author";
            this.AuthSearchRad.UseVisualStyleBackColor = true;
            // 
            // CategorySearchRad
            // 
            this.CategorySearchRad.AutoSize = true;
            this.CategorySearchRad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CategorySearchRad.Location = new System.Drawing.Point(416, 35);
            this.CategorySearchRad.Name = "CategorySearchRad";
            this.CategorySearchRad.Size = new System.Drawing.Size(73, 18);
            this.CategorySearchRad.TabIndex = 18;
            this.CategorySearchRad.TabStop = true;
            this.CategorySearchRad.Text = "Category";
            this.CategorySearchRad.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Author";
            // 
            // authName
            // 
            this.authName.Location = new System.Drawing.Point(112, 89);
            this.authName.Name = "authName";
            this.authName.Size = new System.Drawing.Size(534, 20);
            this.authName.TabIndex = 23;
            this.authName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.authName_KeyUp);
            // 
            // bookSearchButton
            // 
            this.bookSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bookSearchButton.Location = new System.Drawing.Point(551, 30);
            this.bookSearchButton.Name = "bookSearchButton";
            this.bookSearchButton.Size = new System.Drawing.Size(75, 23);
            this.bookSearchButton.TabIndex = 24;
            this.bookSearchButton.Text = "Search";
            this.bookSearchButton.UseVisualStyleBackColor = true;
            this.bookSearchButton.Click += new System.EventHandler(this.bookSearchButton_Click);
            // 
            // proceedButton
            // 
            this.proceedButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.proceedButton.Location = new System.Drawing.Point(571, 341);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(75, 23);
            this.proceedButton.TabIndex = 25;
            this.proceedButton.Text = "Proceed";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // titleSearchRad
            // 
            this.titleSearchRad.AutoSize = true;
            this.titleSearchRad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.titleSearchRad.Location = new System.Drawing.Point(5, 35);
            this.titleSearchRad.Name = "titleSearchRad";
            this.titleSearchRad.Size = new System.Drawing.Size(51, 18);
            this.titleSearchRad.TabIndex = 27;
            this.titleSearchRad.TabStop = true;
            this.titleSearchRad.Text = "Title";
            this.titleSearchRad.UseVisualStyleBackColor = true;
            // 
            // checkYear
            // 
            this.checkYear.AutoSize = true;
            this.checkYear.Location = new System.Drawing.Point(309, 64);
            this.checkYear.Name = "checkYear";
            this.checkYear.Size = new System.Drawing.Size(128, 17);
            this.checkYear.TabIndex = 29;
            this.checkYear.Text = "Published year check";
            this.checkYear.UseVisualStyleBackColor = true;
            this.checkYear.CheckStateChanged += new System.EventHandler(this.checkYear_CheckStateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.titleSearchRad);
            this.groupBox1.Controls.Add(this.CategorySearchRad);
            this.groupBox1.Controls.Add(this.AuthSearchRad);
            this.groupBox1.Controls.Add(this.bookSearchButton);
            this.groupBox1.Controls.Add(this.ISBNsearchRad);
            this.groupBox1.Location = new System.Drawing.Point(11, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 81);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search criteria";
            // 
            // QuarksMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 373);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkYear);
            this.Controls.Add(this.proceedButton);
            this.Controls.Add(this.authName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toText);
            this.Controls.Add(this.fromText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categorySelect);
            this.Controls.Add(this.bookCategory);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.searchFor);
            this.Controls.Add(this.bookData);
            this.Controls.Add(this.bookDetails);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "QuarksMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quarks Library";
            this.Load += new System.EventHandler(this.QuarksMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label bookDetails;
        private System.Windows.Forms.DataGridView bookData;
        private System.Windows.Forms.Label searchFor;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Label bookCategory;
        private System.Windows.Forms.ComboBox categorySelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fromText;
        private System.Windows.Forms.TextBox toText;
        private System.Windows.Forms.RadioButton ISBNsearchRad;
        private System.Windows.Forms.RadioButton AuthSearchRad;
        private System.Windows.Forms.RadioButton CategorySearchRad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox authName;
        private System.Windows.Forms.Button bookSearchButton;
        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllSubscribersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDeleteUpdateBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRemoveSubscribersToolStripMenuItem;
        private System.Windows.Forms.RadioButton titleSearchRad;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox checkYear;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


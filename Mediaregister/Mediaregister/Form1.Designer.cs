
namespace Mediaregister
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_director = new System.Windows.Forms.TextBox();
            this.btn_addFilm = new System.Windows.Forms.Button();
            this.tbx_filmTitle = new System.Windows.Forms.TextBox();
            this.nud_legnth = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_addBook = new System.Windows.Forms.Button();
            this.nud_nrOfPages = new System.Windows.Forms.NumericUpDown();
            this.tbx_bookTitle = new System.Windows.Forms.TextBox();
            this.tbx_author = new System.Windows.Forms.TextBox();
            this.rtf_display = new System.Windows.Forms.RichTextBox();
            this.rbtn_all = new System.Windows.Forms.RadioButton();
            this.rbtn_books = new System.Windows.Forms.RadioButton();
            this.rbtn_films = new System.Windows.Forms.RadioButton();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_addNewProfile = new System.Windows.Forms.Button();
            this.tbx_newProfile = new System.Windows.Forms.TextBox();
            this.lbx_availableProfiles = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_legnth)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_nrOfPages)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(252, 67);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(246, 292);
            this.tabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbx_director);
            this.tabPage1.Controls.Add(this.btn_addFilm);
            this.tabPage1.Controls.Add(this.tbx_filmTitle);
            this.tabPage1.Controls.Add(this.nud_legnth);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(238, 266);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add film";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Legnth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Director:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title:";
            // 
            // tbx_director
            // 
            this.tbx_director.Location = new System.Drawing.Point(109, 28);
            this.tbx_director.Name = "tbx_director";
            this.tbx_director.Size = new System.Drawing.Size(114, 20);
            this.tbx_director.TabIndex = 1;
            
            // 
            // btn_addFilm
            // 
            this.btn_addFilm.Location = new System.Drawing.Point(63, 208);
            this.btn_addFilm.Name = "btn_addFilm";
            this.btn_addFilm.Size = new System.Drawing.Size(114, 23);
            this.btn_addFilm.TabIndex = 3;
            this.btn_addFilm.Text = "Add film";
            this.btn_addFilm.UseVisualStyleBackColor = true;
            this.btn_addFilm.Click += new System.EventHandler(this.Btn_AddFilm_Click);
            // 
            // tbx_filmTitle
            // 
            this.tbx_filmTitle.Location = new System.Drawing.Point(109, 54);
            this.tbx_filmTitle.Name = "tbx_filmTitle";
            this.tbx_filmTitle.Size = new System.Drawing.Size(114, 20);
            this.tbx_filmTitle.TabIndex = 0;
          
            // 
            // nud_legnth
            // 
            this.nud_legnth.Location = new System.Drawing.Point(109, 80);
            this.nud_legnth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_legnth.Name = "nud_legnth";
            this.nud_legnth.Size = new System.Drawing.Size(114, 20);
            this.nud_legnth.TabIndex = 2;
           
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btn_addBook);
            this.tabPage2.Controls.Add(this.nud_nrOfPages);
            this.tabPage2.Controls.Add(this.tbx_bookTitle);
            this.tabPage2.Controls.Add(this.tbx_author);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(238, 266);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add book";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Pages:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Author:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Title:";
            // 
            // btn_addBook
            // 
            this.btn_addBook.Location = new System.Drawing.Point(63, 208);
            this.btn_addBook.Name = "btn_addBook";
            this.btn_addBook.Size = new System.Drawing.Size(114, 23);
            this.btn_addBook.TabIndex = 3;
            this.btn_addBook.Text = "Add book";
            this.btn_addBook.UseVisualStyleBackColor = true;
            this.btn_addBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // nud_nrOfPages
            // 
            this.nud_nrOfPages.Location = new System.Drawing.Point(109, 80);
            this.nud_nrOfPages.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_nrOfPages.Name = "nud_nrOfPages";
            this.nud_nrOfPages.Size = new System.Drawing.Size(114, 20);
            this.nud_nrOfPages.TabIndex = 2;
           
            // 
            // tbx_bookTitle
            // 
            this.tbx_bookTitle.Location = new System.Drawing.Point(109, 28);
            this.tbx_bookTitle.Name = "tbx_bookTitle";
            this.tbx_bookTitle.Size = new System.Drawing.Size(114, 20);
            this.tbx_bookTitle.TabIndex = 1;
        
            // 
            // tbx_author
            // 
            this.tbx_author.Location = new System.Drawing.Point(109, 54);
            this.tbx_author.Name = "tbx_author";
            this.tbx_author.Size = new System.Drawing.Size(114, 20);
            this.tbx_author.TabIndex = 0;
           
            // 
            // rtf_display
            // 
            this.rtf_display.BackColor = System.Drawing.Color.White;
            this.rtf_display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtf_display.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtf_display.Location = new System.Drawing.Point(519, 89);
            this.rtf_display.Name = "rtf_display";
            this.rtf_display.ReadOnly = true;
            this.rtf_display.Size = new System.Drawing.Size(246, 266);
            this.rtf_display.TabIndex = 6;
            this.rtf_display.Text = "";
            // 
            // rbtn_all
            // 
            this.rbtn_all.AutoSize = true;
            this.rbtn_all.Checked = true;
            this.rbtn_all.Location = new System.Drawing.Point(515, 364);
            this.rbtn_all.Name = "rbtn_all";
            this.rbtn_all.Size = new System.Drawing.Size(36, 17);
            this.rbtn_all.TabIndex = 4;
            this.rbtn_all.TabStop = true;
            this.rbtn_all.Text = "All";
            this.rbtn_all.UseVisualStyleBackColor = true;
            this.rbtn_all.CheckedChanged += new System.EventHandler(this.rbtn_all_CheckedChanged);
            // 
            // rbtn_books
            // 
            this.rbtn_books.AutoSize = true;
            this.rbtn_books.Location = new System.Drawing.Point(556, 364);
            this.rbtn_books.Name = "rbtn_books";
            this.rbtn_books.Size = new System.Drawing.Size(55, 17);
            this.rbtn_books.TabIndex = 7;
            this.rbtn_books.Text = "Books";
            this.rbtn_books.UseVisualStyleBackColor = true;
            this.rbtn_books.CheckedChanged += new System.EventHandler(this.rbtn_books_CheckedChanged);
            // 
            // rbtn_films
            // 
            this.rbtn_films.AutoSize = true;
            this.rbtn_films.Location = new System.Drawing.Point(616, 364);
            this.rbtn_films.Name = "rbtn_films";
            this.rbtn_films.Size = new System.Drawing.Size(48, 17);
            this.rbtn_films.TabIndex = 8;
            this.rbtn_films.Text = "Films";
            this.rbtn_films.UseVisualStyleBackColor = true;
            this.rbtn_films.CheckedChanged += new System.EventHandler(this.rbtn_films_CheckedChanged);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(690, 361);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save as";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_addNewProfile
            // 
            this.btn_addNewProfile.Location = new System.Drawing.Point(101, 242);
            this.btn_addNewProfile.Name = "btn_addNewProfile";
            this.btn_addNewProfile.Size = new System.Drawing.Size(114, 23);
            this.btn_addNewProfile.TabIndex = 10;
            this.btn_addNewProfile.Text = "Create profile";
            this.btn_addNewProfile.UseVisualStyleBackColor = true;
            this.btn_addNewProfile.Click += new System.EventHandler(this.btn_addNewProfile_Click);
            // 
            // tbx_newProfile
            // 
            this.tbx_newProfile.Location = new System.Drawing.Point(101, 206);
            this.tbx_newProfile.Name = "tbx_newProfile";
            this.tbx_newProfile.Size = new System.Drawing.Size(114, 20);
            this.tbx_newProfile.TabIndex = 11;
            // 
            // lbx_availableProfiles
            // 
            this.lbx_availableProfiles.FormattingEnabled = true;
            this.lbx_availableProfiles.Location = new System.Drawing.Point(101, 94);
            this.lbx_availableProfiles.Name = "lbx_availableProfiles";
            this.lbx_availableProfiles.Size = new System.Drawing.Size(114, 95);
            this.lbx_availableProfiles.TabIndex = 12;
            this.lbx_availableProfiles.SelectedIndexChanged += new System.EventHandler(this.lbx_availableProfiles_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbx_availableProfiles);
            this.Controls.Add(this.tbx_newProfile);
            this.Controls.Add(this.btn_addNewProfile);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.rbtn_films);
            this.Controls.Add(this.rbtn_books);
            this.Controls.Add(this.rbtn_all);
            this.Controls.Add(this.rtf_display);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Media register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_legnth)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_nrOfPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rtf_display;
        private System.Windows.Forms.RadioButton rbtn_all;
        private System.Windows.Forms.RadioButton rbtn_books;
        private System.Windows.Forms.RadioButton rbtn_films;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbx_director;
        private System.Windows.Forms.Button btn_addFilm;
        private System.Windows.Forms.TextBox tbx_filmTitle;
        private System.Windows.Forms.NumericUpDown nud_legnth;
        private System.Windows.Forms.NumericUpDown nud_nrOfPages;
        private System.Windows.Forms.TextBox tbx_bookTitle;
        private System.Windows.Forms.TextBox tbx_author;
        private System.Windows.Forms.Button btn_addBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_addNewProfile;
        private System.Windows.Forms.TextBox tbx_newProfile;
        private System.Windows.Forms.ListBox lbx_availableProfiles;
        private System.Windows.Forms.Label label7;
    }
}


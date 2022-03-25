namespace LibraryGUI
{
    partial class FormLibrary
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBook = new System.Windows.Forms.TabPage();
            this.tabPageReader = new System.Windows.Forms.TabPage();
            this.tabPageSubscription = new System.Windows.Forms.TabPage();
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.labelBookTitle = new System.Windows.Forms.Label();
            this.textBoxBookTtile = new System.Windows.Forms.TextBox();
            this.domainUpDownPagesCount = new System.Windows.Forms.DomainUpDown();
            this.dateTimePickerBookDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.comboBoxAuthorName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonSelectBook = new System.Windows.Forms.Button();
            this.buttonUpdateBook = new System.Windows.Forms.Button();
            this.buttonUpdateReader = new System.Windows.Forms.Button();
            this.buttonSelectReader = new System.Windows.Forms.Button();
            this.buttonAddReader = new System.Windows.Forms.Button();
            this.dateTimePickerReaderBirthday = new System.Windows.Forms.DateTimePicker();
            this.textBoxReaderName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewReader = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxReaderOrganization = new System.Windows.Forms.TextBox();
            this.buttonUpdateSubscription = new System.Windows.Forms.Button();
            this.buttonSelectSubscription = new System.Windows.Forms.Button();
            this.buttonAddSubscription = new System.Windows.Forms.Button();
            this.comboBoxBook = new System.Windows.Forms.ComboBox();
            this.dateTimePickerTookDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewSubscription = new System.Windows.Forms.DataGridView();
            this.comboBoxReader = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerBroughtDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxIsReturnBook = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageBook.SuspendLayout();
            this.tabPageReader.SuspendLayout();
            this.tabPageSubscription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubscription)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBook);
            this.tabControl1.Controls.Add(this.tabPageReader);
            this.tabControl1.Controls.Add(this.tabPageSubscription);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageBook
            // 
            this.tabPageBook.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageBook.Controls.Add(this.buttonUpdateBook);
            this.tabPageBook.Controls.Add(this.buttonSelectBook);
            this.tabPageBook.Controls.Add(this.buttonAddBook);
            this.tabPageBook.Controls.Add(this.comboBoxAuthorName);
            this.tabPageBook.Controls.Add(this.buttonAddAuthor);
            this.tabPageBook.Controls.Add(this.dateTimePickerBookDate);
            this.tabPageBook.Controls.Add(this.domainUpDownPagesCount);
            this.tabPageBook.Controls.Add(this.textBoxBookTtile);
            this.tabPageBook.Controls.Add(this.label3);
            this.tabPageBook.Controls.Add(this.label2);
            this.tabPageBook.Controls.Add(this.label1);
            this.tabPageBook.Controls.Add(this.labelBookTitle);
            this.tabPageBook.Controls.Add(this.dataGridViewBook);
            this.tabPageBook.Location = new System.Drawing.Point(4, 24);
            this.tabPageBook.Name = "tabPageBook";
            this.tabPageBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBook.Size = new System.Drawing.Size(792, 422);
            this.tabPageBook.TabIndex = 0;
            this.tabPageBook.Text = "Книги";
            // 
            // tabPageReader
            // 
            this.tabPageReader.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageReader.Controls.Add(this.buttonUpdateReader);
            this.tabPageReader.Controls.Add(this.buttonSelectReader);
            this.tabPageReader.Controls.Add(this.buttonAddReader);
            this.tabPageReader.Controls.Add(this.dateTimePickerReaderBirthday);
            this.tabPageReader.Controls.Add(this.textBoxReaderOrganization);
            this.tabPageReader.Controls.Add(this.textBoxReaderName);
            this.tabPageReader.Controls.Add(this.label5);
            this.tabPageReader.Controls.Add(this.label4);
            this.tabPageReader.Controls.Add(this.label7);
            this.tabPageReader.Controls.Add(this.dataGridViewReader);
            this.tabPageReader.Location = new System.Drawing.Point(4, 24);
            this.tabPageReader.Name = "tabPageReader";
            this.tabPageReader.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReader.Size = new System.Drawing.Size(792, 422);
            this.tabPageReader.TabIndex = 1;
            this.tabPageReader.Text = "Посетители";
            // 
            // tabPageSubscription
            // 
            this.tabPageSubscription.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSubscription.Controls.Add(this.textBoxIsReturnBook);
            this.tabPageSubscription.Controls.Add(this.label10);
            this.tabPageSubscription.Controls.Add(this.comboBoxReader);
            this.tabPageSubscription.Controls.Add(this.label11);
            this.tabPageSubscription.Controls.Add(this.buttonUpdateSubscription);
            this.tabPageSubscription.Controls.Add(this.buttonSelectSubscription);
            this.tabPageSubscription.Controls.Add(this.buttonAddSubscription);
            this.tabPageSubscription.Controls.Add(this.comboBoxBook);
            this.tabPageSubscription.Controls.Add(this.dateTimePickerBroughtDate);
            this.tabPageSubscription.Controls.Add(this.label8);
            this.tabPageSubscription.Controls.Add(this.dateTimePickerTookDate);
            this.tabPageSubscription.Controls.Add(this.label6);
            this.tabPageSubscription.Controls.Add(this.label9);
            this.tabPageSubscription.Controls.Add(this.dataGridViewSubscription);
            this.tabPageSubscription.Location = new System.Drawing.Point(4, 24);
            this.tabPageSubscription.Name = "tabPageSubscription";
            this.tabPageSubscription.Size = new System.Drawing.Size(792, 422);
            this.tabPageSubscription.TabIndex = 2;
            this.tabPageSubscription.Text = "Абонименты";
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewBook.Location = new System.Drawing.Point(238, 3);
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.RowTemplate.Height = 25;
            this.dataGridViewBook.Size = new System.Drawing.Size(551, 416);
            this.dataGridViewBook.TabIndex = 0;
            // 
            // labelBookTitle
            // 
            this.labelBookTitle.AutoSize = true;
            this.labelBookTitle.Location = new System.Drawing.Point(8, 11);
            this.labelBookTitle.Name = "labelBookTitle";
            this.labelBookTitle.Size = new System.Drawing.Size(65, 15);
            this.labelBookTitle.TabIndex = 1;
            this.labelBookTitle.Text = "Название :";
            // 
            // textBoxBookTtile
            // 
            this.textBoxBookTtile.Location = new System.Drawing.Point(8, 29);
            this.textBoxBookTtile.Name = "textBoxBookTtile";
            this.textBoxBookTtile.Size = new System.Drawing.Size(224, 23);
            this.textBoxBookTtile.TabIndex = 2;
            // 
            // domainUpDownPagesCount
            // 
            this.domainUpDownPagesCount.Location = new System.Drawing.Point(8, 140);
            this.domainUpDownPagesCount.Name = "domainUpDownPagesCount";
            this.domainUpDownPagesCount.Size = new System.Drawing.Size(224, 23);
            this.domainUpDownPagesCount.TabIndex = 3;
            this.domainUpDownPagesCount.Text = "domainUpDown1";
            // 
            // dateTimePickerBookDate
            // 
            this.dateTimePickerBookDate.Location = new System.Drawing.Point(8, 195);
            this.dateTimePickerBookDate.Name = "dateTimePickerBookDate";
            this.dateTimePickerBookDate.Size = new System.Drawing.Size(224, 23);
            this.dateTimePickerBookDate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Автор :";
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Location = new System.Drawing.Point(210, 84);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(22, 23);
            this.buttonAddAuthor.TabIndex = 5;
            this.buttonAddAuthor.Text = "+";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            // 
            // comboBoxAuthorName
            // 
            this.comboBoxAuthorName.FormattingEnabled = true;
            this.comboBoxAuthorName.Location = new System.Drawing.Point(8, 84);
            this.comboBoxAuthorName.Name = "comboBoxAuthorName";
            this.comboBoxAuthorName.Size = new System.Drawing.Size(196, 23);
            this.comboBoxAuthorName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кол-во страниц :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Дата :";
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(8, 243);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(224, 25);
            this.buttonAddBook.TabIndex = 7;
            this.buttonAddBook.Text = "Добавить";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            // 
            // buttonSelectBook
            // 
            this.buttonSelectBook.Location = new System.Drawing.Point(8, 285);
            this.buttonSelectBook.Name = "buttonSelectBook";
            this.buttonSelectBook.Size = new System.Drawing.Size(224, 25);
            this.buttonSelectBook.TabIndex = 7;
            this.buttonSelectBook.Text = "Получить";
            this.buttonSelectBook.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateBook
            // 
            this.buttonUpdateBook.Location = new System.Drawing.Point(8, 326);
            this.buttonUpdateBook.Name = "buttonUpdateBook";
            this.buttonUpdateBook.Size = new System.Drawing.Size(224, 25);
            this.buttonUpdateBook.TabIndex = 7;
            this.buttonUpdateBook.Text = "Обновить";
            this.buttonUpdateBook.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateReader
            // 
            this.buttonUpdateReader.Location = new System.Drawing.Point(5, 273);
            this.buttonUpdateReader.Name = "buttonUpdateReader";
            this.buttonUpdateReader.Size = new System.Drawing.Size(224, 25);
            this.buttonUpdateReader.TabIndex = 18;
            this.buttonUpdateReader.Text = "Обновить";
            this.buttonUpdateReader.UseVisualStyleBackColor = true;
            // 
            // buttonSelectReader
            // 
            this.buttonSelectReader.Location = new System.Drawing.Point(5, 232);
            this.buttonSelectReader.Name = "buttonSelectReader";
            this.buttonSelectReader.Size = new System.Drawing.Size(224, 25);
            this.buttonSelectReader.TabIndex = 19;
            this.buttonSelectReader.Text = "Получить";
            this.buttonSelectReader.UseVisualStyleBackColor = true;
            // 
            // buttonAddReader
            // 
            this.buttonAddReader.Location = new System.Drawing.Point(5, 190);
            this.buttonAddReader.Name = "buttonAddReader";
            this.buttonAddReader.Size = new System.Drawing.Size(224, 25);
            this.buttonAddReader.TabIndex = 20;
            this.buttonAddReader.Text = "Добавить";
            this.buttonAddReader.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerReaderBirthday
            // 
            this.dateTimePickerReaderBirthday.Location = new System.Drawing.Point(5, 142);
            this.dateTimePickerReaderBirthday.Name = "dateTimePickerReaderBirthday";
            this.dateTimePickerReaderBirthday.Size = new System.Drawing.Size(224, 23);
            this.dateTimePickerReaderBirthday.TabIndex = 15;
            // 
            // textBoxReaderName
            // 
            this.textBoxReaderName.Location = new System.Drawing.Point(6, 29);
            this.textBoxReaderName.Name = "textBoxReaderName";
            this.textBoxReaderName.Size = new System.Drawing.Size(224, 23);
            this.textBoxReaderName.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "День рождения :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Имя :";
            // 
            // dataGridViewReader
            // 
            this.dataGridViewReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReader.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewReader.Location = new System.Drawing.Point(238, 3);
            this.dataGridViewReader.Name = "dataGridViewReader";
            this.dataGridViewReader.RowTemplate.Height = 25;
            this.dataGridViewReader.Size = new System.Drawing.Size(551, 416);
            this.dataGridViewReader.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Организация :";
            // 
            // textBoxReaderOrganization
            // 
            this.textBoxReaderOrganization.Location = new System.Drawing.Point(6, 87);
            this.textBoxReaderOrganization.Name = "textBoxReaderOrganization";
            this.textBoxReaderOrganization.Size = new System.Drawing.Size(224, 23);
            this.textBoxReaderOrganization.TabIndex = 13;
            // 
            // buttonUpdateSubscription
            // 
            this.buttonUpdateSubscription.Location = new System.Drawing.Point(4, 381);
            this.buttonUpdateSubscription.Name = "buttonUpdateSubscription";
            this.buttonUpdateSubscription.Size = new System.Drawing.Size(224, 25);
            this.buttonUpdateSubscription.TabIndex = 18;
            this.buttonUpdateSubscription.Text = "Обновить";
            this.buttonUpdateSubscription.UseVisualStyleBackColor = true;
            // 
            // buttonSelectSubscription
            // 
            this.buttonSelectSubscription.Location = new System.Drawing.Point(4, 340);
            this.buttonSelectSubscription.Name = "buttonSelectSubscription";
            this.buttonSelectSubscription.Size = new System.Drawing.Size(224, 25);
            this.buttonSelectSubscription.TabIndex = 19;
            this.buttonSelectSubscription.Text = "Получить";
            this.buttonSelectSubscription.UseVisualStyleBackColor = true;
            // 
            // buttonAddSubscription
            // 
            this.buttonAddSubscription.Location = new System.Drawing.Point(4, 298);
            this.buttonAddSubscription.Name = "buttonAddSubscription";
            this.buttonAddSubscription.Size = new System.Drawing.Size(224, 25);
            this.buttonAddSubscription.TabIndex = 20;
            this.buttonAddSubscription.Text = "Добавить";
            this.buttonAddSubscription.UseVisualStyleBackColor = true;
            // 
            // comboBoxBook
            // 
            this.comboBoxBook.FormattingEnabled = true;
            this.comboBoxBook.Location = new System.Drawing.Point(4, 27);
            this.comboBoxBook.Name = "comboBoxBook";
            this.comboBoxBook.Size = new System.Drawing.Size(224, 23);
            this.comboBoxBook.TabIndex = 17;
            // 
            // dateTimePickerTookDate
            // 
            this.dateTimePickerTookDate.Location = new System.Drawing.Point(4, 136);
            this.dateTimePickerTookDate.Name = "dateTimePickerTookDate";
            this.dateTimePickerTookDate.Size = new System.Drawing.Size(224, 23);
            this.dateTimePickerTookDate.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Дата получения книги :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Книга :";
            // 
            // dataGridViewSubscription
            // 
            this.dataGridViewSubscription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubscription.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewSubscription.Location = new System.Drawing.Point(241, 0);
            this.dataGridViewSubscription.Name = "dataGridViewSubscription";
            this.dataGridViewSubscription.RowTemplate.Height = 25;
            this.dataGridViewSubscription.Size = new System.Drawing.Size(551, 422);
            this.dataGridViewSubscription.TabIndex = 8;
            // 
            // comboBoxReader
            // 
            this.comboBoxReader.FormattingEnabled = true;
            this.comboBoxReader.Location = new System.Drawing.Point(4, 80);
            this.comboBoxReader.Name = "comboBoxReader";
            this.comboBoxReader.Size = new System.Drawing.Size(224, 23);
            this.comboBoxReader.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Читатель :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Дата возврата книги :";
            // 
            // dateTimePickerBroughtDate
            // 
            this.dateTimePickerBroughtDate.Location = new System.Drawing.Point(4, 191);
            this.dateTimePickerBroughtDate.Name = "dateTimePickerBroughtDate";
            this.dateTimePickerBroughtDate.Size = new System.Drawing.Size(224, 23);
            this.dateTimePickerBroughtDate.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "Статус возврата :";
            // 
            // textBoxIsReturnBook
            // 
            this.textBoxIsReturnBook.Location = new System.Drawing.Point(3, 249);
            this.textBoxIsReturnBook.Name = "textBoxIsReturnBook";
            this.textBoxIsReturnBook.Size = new System.Drawing.Size(224, 23);
            this.textBoxIsReturnBook.TabIndex = 25;
            // 
            // FormLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormLibrary";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.FormLibrary_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageBook.ResumeLayout(false);
            this.tabPageBook.PerformLayout();
            this.tabPageReader.ResumeLayout(false);
            this.tabPageReader.PerformLayout();
            this.tabPageSubscription.ResumeLayout(false);
            this.tabPageSubscription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubscription)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageBook;
        private DateTimePicker dateTimePickerBookDate;
        private DomainUpDown domainUpDownPagesCount;
        private TextBox textBoxBookTtile;
        private Label labelBookTitle;
        private DataGridView dataGridViewBook;
        private TabPage tabPageReader;
        private TabPage tabPageSubscription;
        private ComboBox comboBoxAuthorName;
        private Button buttonAddAuthor;
        private Label label2;
        private Label label1;
        private Button buttonUpdateBook;
        private Button buttonSelectBook;
        private Button buttonAddBook;
        private Label label3;
        private Button buttonUpdateReader;
        private Button buttonSelectReader;
        private Button buttonAddReader;
        private DateTimePicker dateTimePickerReaderBirthday;
        private TextBox textBoxReaderOrganization;
        private TextBox textBoxReaderName;
        private Label label5;
        private Label label4;
        private Label label7;
        private DataGridView dataGridViewReader;
        private TextBox textBoxIsReturnBook;
        private Label label10;
        private ComboBox comboBoxReader;
        private Label label11;
        private Button buttonUpdateSubscription;
        private Button buttonSelectSubscription;
        private Button buttonAddSubscription;
        private ComboBox comboBoxBook;
        private DateTimePicker dateTimePickerBroughtDate;
        private Label label8;
        private DateTimePicker dateTimePickerTookDate;
        private Label label6;
        private Label label9;
        private DataGridView dataGridViewSubscription;
    }
}
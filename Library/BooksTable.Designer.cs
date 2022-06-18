namespace Library
{
    partial class BooksTable
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
            this.listView_BooksTable = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.BookName = new System.Windows.Forms.ColumnHeader();
            this.BookGenre = new System.Windows.Forms.ColumnHeader();
            this.PageCount = new System.Windows.Forms.ColumnHeader();
            this.PublishingYear = new System.Windows.Forms.ColumnHeader();
            this.BookIssue = new System.Windows.Forms.ColumnHeader();
            this.textBox_SearchedName = new System.Windows.Forms.TextBox();
            this.label_SearchOrDeleteInput = new System.Windows.Forms.Label();
            this.button_FindBook = new System.Windows.Forms.Button();
            this.button_DeleteBook = new System.Windows.Forms.Button();
            this.button_AddEntryToDB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_MinPages = new System.Windows.Forms.TextBox();
            this.textBox_MaxPages = new System.Windows.Forms.TextBox();
            this.label_PagesFilter = new System.Windows.Forms.Label();
            this.label_Dash = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label_AboutSelectingBooks = new System.Windows.Forms.Label();
            this.checkedListBox_GenreSelect = new System.Windows.Forms.CheckedListBox();
            this.button_SaveEdits = new System.Windows.Forms.Button();
            this.errorProvider_Pages = new System.Windows.Forms.ErrorProvider(this.components);
            this.label_RefreshForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Pages)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_BooksTable
            // 
            this.listView_BooksTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.BookName,
            this.BookGenre,
            this.PageCount,
            this.PublishingYear,
            this.BookIssue});
            this.listView_BooksTable.FullRowSelect = true;
            this.listView_BooksTable.GridLines = true;
            this.listView_BooksTable.Location = new System.Drawing.Point(13, 12);
            this.listView_BooksTable.MultiSelect = false;
            this.listView_BooksTable.Name = "listView_BooksTable";
            this.listView_BooksTable.Size = new System.Drawing.Size(794, 450);
            this.listView_BooksTable.TabIndex = 0;
            this.listView_BooksTable.UseCompatibleStateImageBehavior = false;
            this.listView_BooksTable.View = System.Windows.Forms.View.Details;
            this.listView_BooksTable.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_BooksTable_ColumnClick);
            this.listView_BooksTable.SelectedIndexChanged += new System.EventHandler(this.listView_BooksTable_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 30;
            // 
            // BookName
            // 
            this.BookName.Text = "Название";
            this.BookName.Width = 150;
            // 
            // BookGenre
            // 
            this.BookGenre.Text = "Жанр";
            this.BookGenre.Width = 100;
            // 
            // PageCount
            // 
            this.PageCount.Text = "Количество страниц";
            this.PageCount.Width = 130;
            // 
            // PublishingYear
            // 
            this.PublishingYear.Text = "Год издания";
            this.PublishingYear.Width = 100;
            // 
            // BookIssue
            // 
            this.BookIssue.Text = "Номер издания";
            this.BookIssue.Width = 100;
            // 
            // textBox_SearchedName
            // 
            this.textBox_SearchedName.Location = new System.Drawing.Point(847, 210);
            this.textBox_SearchedName.Name = "textBox_SearchedName";
            this.textBox_SearchedName.PlaceholderText = "Название книги";
            this.textBox_SearchedName.Size = new System.Drawing.Size(190, 23);
            this.textBox_SearchedName.TabIndex = 1;
            // 
            // label_SearchOrDeleteInput
            // 
            this.label_SearchOrDeleteInput.AutoSize = true;
            this.label_SearchOrDeleteInput.Location = new System.Drawing.Point(825, 12);
            this.label_SearchOrDeleteInput.Name = "label_SearchOrDeleteInput";
            this.label_SearchOrDeleteInput.Size = new System.Drawing.Size(128, 15);
            this.label_SearchOrDeleteInput.TabIndex = 2;
            this.label_SearchOrDeleteInput.Text = "Управление таблицей";
            // 
            // button_FindBook
            // 
            this.button_FindBook.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_FindBook.Location = new System.Drawing.Point(846, 413);
            this.button_FindBook.Name = "button_FindBook";
            this.button_FindBook.Size = new System.Drawing.Size(190, 25);
            this.button_FindBook.TabIndex = 4;
            this.button_FindBook.Text = "Найти книгу";
            this.button_FindBook.UseVisualStyleBackColor = false;
            this.button_FindBook.Click += new System.EventHandler(this.button_FindBook_Click);
            // 
            // button_DeleteBook
            // 
            this.button_DeleteBook.Enabled = false;
            this.button_DeleteBook.Location = new System.Drawing.Point(827, 89);
            this.button_DeleteBook.Name = "button_DeleteBook";
            this.button_DeleteBook.Size = new System.Drawing.Size(234, 39);
            this.button_DeleteBook.TabIndex = 5;
            this.button_DeleteBook.Text = "Удалить книгу";
            this.button_DeleteBook.UseVisualStyleBackColor = true;
            this.button_DeleteBook.Click += new System.EventHandler(this.button_DeleteBook_Click);
            // 
            // button_AddEntryToDB
            // 
            this.button_AddEntryToDB.Location = new System.Drawing.Point(827, 36);
            this.button_AddEntryToDB.Name = "button_AddEntryToDB";
            this.button_AddEntryToDB.Size = new System.Drawing.Size(234, 39);
            this.button_AddEntryToDB.TabIndex = 6;
            this.button_AddEntryToDB.Text = "Добавить новую позицию";
            this.button_AddEntryToDB.UseVisualStyleBackColor = true;
            this.button_AddEntryToDB.Click += new System.EventHandler(this.button_AddEntryToDB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(827, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 320);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_MinPages
            // 
            this.textBox_MinPages.Location = new System.Drawing.Point(847, 265);
            this.textBox_MinPages.Name = "textBox_MinPages";
            this.textBox_MinPages.PlaceholderText = "0";
            this.textBox_MinPages.Size = new System.Drawing.Size(76, 23);
            this.textBox_MinPages.TabIndex = 8;
            this.textBox_MinPages.TextChanged += new System.EventHandler(this.textBox_MinPages_TextChanged);
            // 
            // textBox_MaxPages
            // 
            this.textBox_MaxPages.Location = new System.Drawing.Point(960, 265);
            this.textBox_MaxPages.Name = "textBox_MaxPages";
            this.textBox_MaxPages.PlaceholderText = "9999";
            this.textBox_MaxPages.Size = new System.Drawing.Size(76, 23);
            this.textBox_MaxPages.TabIndex = 9;
            this.textBox_MaxPages.TextChanged += new System.EventHandler(this.textBox_MaxPages_TextChanged);
            // 
            // label_PagesFilter
            // 
            this.label_PagesFilter.AutoSize = true;
            this.label_PagesFilter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label_PagesFilter.Location = new System.Drawing.Point(847, 247);
            this.label_PagesFilter.Name = "label_PagesFilter";
            this.label_PagesFilter.Size = new System.Drawing.Size(137, 15);
            this.label_PagesFilter.TabIndex = 10;
            this.label_PagesFilter.Text = "По количеству страниц";
            // 
            // label_Dash
            // 
            this.label_Dash.AutoSize = true;
            this.label_Dash.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label_Dash.Location = new System.Drawing.Point(932, 268);
            this.label_Dash.Name = "label_Dash";
            this.label_Dash.Size = new System.Drawing.Size(19, 15);
            this.label_Dash.TabIndex = 11;
            this.label_Dash.Text = "—";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(847, 169);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.PlaceholderText = "По ID";
            this.textBox_ID.Size = new System.Drawing.Size(190, 23);
            this.textBox_ID.TabIndex = 12;
            this.textBox_ID.TextChanged += new System.EventHandler(this.textBox_ID_TextChanged);
            // 
            // label_AboutSelectingBooks
            // 
            this.label_AboutSelectingBooks.AutoSize = true;
            this.label_AboutSelectingBooks.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_AboutSelectingBooks.Location = new System.Drawing.Point(13, 471);
            this.label_AboutSelectingBooks.Name = "label_AboutSelectingBooks";
            this.label_AboutSelectingBooks.Size = new System.Drawing.Size(349, 15);
            this.label_AboutSelectingBooks.TabIndex = 14;
            this.label_AboutSelectingBooks.Text = "Для того, чтобы выделить книгу, достаточно ткнуть по строке";
            // 
            // checkedListBox_GenreSelect
            // 
            this.checkedListBox_GenreSelect.FormattingEnabled = true;
            this.checkedListBox_GenreSelect.Items.AddRange(new object[] {
            "Фэнтези",
            "Роман",
            "Журнал",
            "Газета"});
            this.checkedListBox_GenreSelect.Location = new System.Drawing.Point(846, 331);
            this.checkedListBox_GenreSelect.Name = "checkedListBox_GenreSelect";
            this.checkedListBox_GenreSelect.Size = new System.Drawing.Size(190, 76);
            this.checkedListBox_GenreSelect.TabIndex = 15;
            // 
            // button_SaveEdits
            // 
            this.button_SaveEdits.Location = new System.Drawing.Point(827, 471);
            this.button_SaveEdits.Name = "button_SaveEdits";
            this.button_SaveEdits.Size = new System.Drawing.Size(234, 37);
            this.button_SaveEdits.TabIndex = 16;
            this.button_SaveEdits.Text = "Сохранить изменения";
            this.button_SaveEdits.UseVisualStyleBackColor = true;
            this.button_SaveEdits.Click += new System.EventHandler(this.button_SaveEdits_Click);
            // 
            // errorProvider_Pages
            // 
            this.errorProvider_Pages.ContainerControl = this;
            // 
            // label_RefreshForm
            // 
            this.label_RefreshForm.AutoSize = true;
            this.label_RefreshForm.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_RefreshForm.Location = new System.Drawing.Point(13, 493);
            this.label_RefreshForm.Name = "label_RefreshForm";
            this.label_RefreshForm.Size = new System.Drawing.Size(499, 15);
            this.label_RefreshForm.TabIndex = 17;
            this.label_RefreshForm.Text = "Если вы добавили элемент в БД, нажмите на кнопку \"Найти книгу\". Это обновит табли" +
    "цу";
            // 
            // BooksTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 523);
            this.Controls.Add(this.label_RefreshForm);
            this.Controls.Add(this.button_SaveEdits);
            this.Controls.Add(this.checkedListBox_GenreSelect);
            this.Controls.Add(this.label_AboutSelectingBooks);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label_Dash);
            this.Controls.Add(this.label_PagesFilter);
            this.Controls.Add(this.textBox_MaxPages);
            this.Controls.Add(this.textBox_MinPages);
            this.Controls.Add(this.button_FindBook);
            this.Controls.Add(this.textBox_SearchedName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_AddEntryToDB);
            this.Controls.Add(this.button_DeleteBook);
            this.Controls.Add(this.label_SearchOrDeleteInput);
            this.Controls.Add(this.listView_BooksTable);
            this.Name = "BooksTable";
            this.Text = "BooksTable";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Pages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView_BooksTable;
        private ColumnHeader BookName;
        private ColumnHeader PageCount;
        private TextBox textBox_SearchedName;
        private Label label_SearchOrDeleteInput;
        private Button button_FindBook;
        private Button button_DeleteBook;
        private Button button_AddEntryToDB;
        private PictureBox pictureBox1;
        private ColumnHeader id;
        private TextBox textBox_MinPages;
        private TextBox textBox_MaxPages;
        private Label label_PagesFilter;
        private Label label_Dash;
        private TextBox textBox_ID;
        private Label label_AboutSelectingBooks;
        private ColumnHeader BookGenre;
        private ColumnHeader PublishingYear;
        private CheckedListBox checkedListBox_GenreSelect;
        private ColumnHeader BookIssue;
        private Button button_SaveEdits;
        private ErrorProvider errorProvider_Pages;
        private Label label_RefreshForm;
    }
}
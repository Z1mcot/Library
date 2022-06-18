namespace Library
{
    partial class AddBookToTable
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
            this.label_AddItemToTable = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.checkedListBox_GenreSelect = new System.Windows.Forms.CheckedListBox();
            this.textBox_PagesCount = new System.Windows.Forms.TextBox();
            this.label_Genre = new System.Windows.Forms.Label();
            this.textBox_YearOfPublishing = new System.Windows.Forms.TextBox();
            this.comboBox_BookType = new System.Windows.Forms.ComboBox();
            this.button_AddEntry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_AddItemToTable
            // 
            this.label_AddItemToTable.AutoSize = true;
            this.label_AddItemToTable.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_AddItemToTable.Location = new System.Drawing.Point(28, 32);
            this.label_AddItemToTable.Name = "label_AddItemToTable";
            this.label_AddItemToTable.Size = new System.Drawing.Size(238, 25);
            this.label_AddItemToTable.TabIndex = 0;
            this.label_AddItemToTable.Text = "Добавить книгу в таблицу";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(28, 147);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.PlaceholderText = "Название книги";
            this.textBox_Name.Size = new System.Drawing.Size(238, 23);
            this.textBox_Name.TabIndex = 1;
            // 
            // checkedListBox_GenreSelect
            // 
            this.checkedListBox_GenreSelect.FormattingEnabled = true;
            this.checkedListBox_GenreSelect.Items.AddRange(new object[] {
            "Фэнтези",
            "Роман",
            "Журнал",
            "Газета"});
            this.checkedListBox_GenreSelect.Location = new System.Drawing.Point(28, 246);
            this.checkedListBox_GenreSelect.Name = "checkedListBox_GenreSelect";
            this.checkedListBox_GenreSelect.Size = new System.Drawing.Size(238, 76);
            this.checkedListBox_GenreSelect.TabIndex = 16;
            // 
            // textBox_PagesCount
            // 
            this.textBox_PagesCount.Location = new System.Drawing.Point(28, 189);
            this.textBox_PagesCount.Name = "textBox_PagesCount";
            this.textBox_PagesCount.PlaceholderText = "Количество страниц";
            this.textBox_PagesCount.Size = new System.Drawing.Size(238, 23);
            this.textBox_PagesCount.TabIndex = 17;
            // 
            // label_Genre
            // 
            this.label_Genre.AutoSize = true;
            this.label_Genre.Location = new System.Drawing.Point(28, 228);
            this.label_Genre.Name = "label_Genre";
            this.label_Genre.Size = new System.Drawing.Size(38, 15);
            this.label_Genre.TabIndex = 18;
            this.label_Genre.Text = "Жанр";
            // 
            // textBox_YearOfPublishing
            // 
            this.textBox_YearOfPublishing.Location = new System.Drawing.Point(28, 341);
            this.textBox_YearOfPublishing.Name = "textBox_YearOfPublishing";
            this.textBox_YearOfPublishing.PlaceholderText = "Год издания (если есть)";
            this.textBox_YearOfPublishing.Size = new System.Drawing.Size(238, 23);
            this.textBox_YearOfPublishing.TabIndex = 19;
            // 
            // comboBox_BookType
            // 
            this.comboBox_BookType.FormattingEnabled = true;
            this.comboBox_BookType.Items.AddRange(new object[] {
            "Книга",
            "Газетное издание"});
            this.comboBox_BookType.Location = new System.Drawing.Point(28, 91);
            this.comboBox_BookType.Name = "comboBox_BookType";
            this.comboBox_BookType.Size = new System.Drawing.Size(238, 23);
            this.comboBox_BookType.TabIndex = 20;
            this.comboBox_BookType.Text = "Тип бумажного издания";
            this.comboBox_BookType.SelectedIndexChanged += new System.EventHandler(this.comboBox_BookType_SelectedIndexChanged);
            // 
            // button_AddEntry
            // 
            this.button_AddEntry.Location = new System.Drawing.Point(28, 390);
            this.button_AddEntry.Name = "button_AddEntry";
            this.button_AddEntry.Size = new System.Drawing.Size(238, 23);
            this.button_AddEntry.TabIndex = 21;
            this.button_AddEntry.Text = "Добавить в таблицу";
            this.button_AddEntry.UseVisualStyleBackColor = true;
            this.button_AddEntry.Click += new System.EventHandler(this.button_AddEntry_Click);
            // 
            // AddBookToTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 450);
            this.Controls.Add(this.button_AddEntry);
            this.Controls.Add(this.comboBox_BookType);
            this.Controls.Add(this.textBox_YearOfPublishing);
            this.Controls.Add(this.label_Genre);
            this.Controls.Add(this.textBox_PagesCount);
            this.Controls.Add(this.checkedListBox_GenreSelect);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_AddItemToTable);
            this.Name = "AddBookToTable";
            this.Text = "AddBookToTable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_AddItemToTable;
        private TextBox textBox_Name;
        private CheckedListBox checkedListBox_GenreSelect;
        private TextBox textBox_PagesCount;
        private Label label_Genre;
        private TextBox textBox_YearOfPublishing;
        private ComboBox comboBox_BookType;
        private Button button_AddEntry;
    }
}
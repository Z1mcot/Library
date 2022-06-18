using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class AddBookToTable : Form
    {
        BooksDatabase booksDatabase;
        Type type;
        public AddBookToTable(BooksDatabase booksDatabase)
        {
            InitializeComponent();
            this.booksDatabase = booksDatabase;
        }

        private void comboBox_BookType_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox_GenreSelect.Items.Clear();
            if (comboBox_BookType.SelectedIndex == 0)
            {
                textBox_YearOfPublishing.PlaceholderText = "Год издания";
                type = typeof(Book);
                checkedListBox_GenreSelect.Items.Add("Фэнтези"); // Чтобы не было соблазна выбрать книгу-газету :)
                checkedListBox_GenreSelect.Items.Add("Роман");
            }
            else
            {
                textBox_YearOfPublishing.PlaceholderText = "Номер издания";
                type = typeof(NewsIssue);
                checkedListBox_GenreSelect.Items.Add("Журнал");
                checkedListBox_GenreSelect.Items.Add("Газета");
            }
        }

        private void button_AddEntry_Click(object sender, EventArgs e)
        {
            var lastId = (booksDatabase.Database[^1] as Literature).Id + 1;// ещё один способ явного приведения типов, тоже самое, что и: (Тип)старая_ссылка
            Literature newBook;
            if (type == typeof(Book)) {
                newBook = new Book(
                    lastId,
                    textBox_Name.Text,
                    checkedListBox_GenreSelect.Text,
                    int.Parse(textBox_PagesCount.Text),
                    int.Parse(textBox_YearOfPublishing.Text));
            }
            else
            {
                newBook = new NewsIssue(
                    lastId,
                    textBox_Name.Text,
                    checkedListBox_GenreSelect.Text,
                    int.Parse(textBox_PagesCount.Text),
                    int.Parse(textBox_YearOfPublishing.Text));
            }
            booksDatabase.Add(newBook);
            this.Close();
        }
    }
}

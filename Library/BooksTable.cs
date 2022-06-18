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
    public partial class BooksTable : Form
    {
        BooksDatabase booksDatabase = new BooksDatabase();
        static string[] _delimiters = { "    ", " " };
        int selectedItem;
        public BooksTable()
        {
            InitializeComponent();

            //загрузка БД из файла
            using (var inputFile = new StreamReader(@"../../../Data/Books.txt"))
            {
                booksDatabase.LoadFromFile(_delimiters, inputFile);
            }

            FillTheTable(booksDatabase);
        }

        private void FillColumns()
        {
            listView_BooksTable.Columns.Add(id);
            listView_BooksTable.Columns.Add(BookName);
            listView_BooksTable.Columns.Add(BookGenre);
            listView_BooksTable.Columns.Add(PageCount);
            listView_BooksTable.Columns.Add(PublishingYear);
            listView_BooksTable.Columns.Add(BookIssue);
        }

        private void FillTheTable(BooksDatabase booksArray)
        {
            listView_BooksTable.Clear();
            int row_num = 0;
            FillColumns();
            foreach (Literature book in booksArray.Database) 
            {
                try
                {
                    listView_BooksTable.Items.Add(book.Id.ToString());
                }
                catch (NullReferenceException)
                {
                    errorProvider_Pages.SetError(textBox_ID, "Нет такой книги!");
                    return;
                }
                finally
                {
                }
                listView_BooksTable.Items[row_num].SubItems.Add(book.Name);
                listView_BooksTable.Items[row_num].SubItems.Add(book.Genre);
                listView_BooksTable.Items[row_num].SubItems.Add(book.PagesCount.ToString());
                if (book.GetType() == typeof(Book))
                {
                    var upscaledBook = (Book)book;
                    listView_BooksTable.Items[row_num].SubItems.Add(upscaledBook.YearOfPublishment.ToString());
                }
                else
                {
                    var upscaledBook = (NewsIssue)book;
                    listView_BooksTable.Items[row_num].SubItems.Add("");
                    listView_BooksTable.Items[row_num].SubItems.Add(upscaledBook.IssueNumber.ToString());
                }
                row_num++;
            }
        }

        private void label_DeleteBook_Click(object sender, EventArgs e)
        {

        }

        private void button_AddEntryToDB_Click(object sender, EventArgs e)
        {
            var addBookToTable = new AddBookToTable(booksDatabase);
            addBookToTable.Show();
            
        }

        private void button_DeleteBook_Click(object sender, EventArgs e)
        {
            // кнопка активна только когда у нас выделена сторока, следовательно проверка не нужна
            var index = listView_BooksTable.SelectedIndices[0];
            var item = listView_BooksTable.Items[index];
            booksDatabase.Remove(int.Parse(item.Text));
            listView_BooksTable.Items.RemoveAt(index);
        }

        private void button_FindBook_Click(object sender, EventArgs e)
        {
            BooksDatabase filteredDatabase = new BooksDatabase { };
            
            var id = textBox_ID.Text;
            var name = textBox_SearchedName.Text;
            var minPages = textBox_MinPages.Text;
            var maxPages = textBox_MaxPages.Text;
            List<string> genres = new List<string>(4);
            foreach (var item in checkedListBox_GenreSelect.CheckedItems)
            {
                genres.Add(item.ToString());
            }

            filteredDatabase = FilterDatabase(id, name, minPages, maxPages, genres);
            FillTheTable(filteredDatabase);
        }

        private BooksDatabase FilterDatabase(string id, string name, string minPages, string maxPages, List<string> genres)
        {
            var filteredDatabase = new BooksDatabase { };
            // По Id. Если ищем по id то остальные поля нас не интересуют
            if (!string.IsNullOrEmpty(id))
            {
                var _id = int.Parse(id);
                filteredDatabase.Add(booksDatabase.FindById(_id));
                return filteredDatabase;
            }
            else filteredDatabase = booksDatabase; // В противном случае, мы бы работали с пустой БД
            
            // По названию
            if (!string.IsNullOrEmpty(name)) filteredDatabase = booksDatabase.FindByName(name);
            
            // По страницам.
            int _minPages = minPages != "" ? int.Parse(minPages) : 0;
            int _maxPages = maxPages != "" ? int.Parse(maxPages) : 9999;
            // Тут не нужно if, т.к. мы уже проверили оба значения на наличия значения когда приводили значения к int
            filteredDatabase = filteredDatabase.FindByPages(_minPages, _maxPages);

            // По жанрам
            if (genres.Count > 0) filteredDatabase = filteredDatabase.FindByGenre(genres);
            
            // Проверка на пустой список
            filteredDatabase = filteredDatabase.Database.Count > 0 ? filteredDatabase : booksDatabase;
            return filteredDatabase;
        }

        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {
            var flag = true;
            if (!string.IsNullOrEmpty(textBox_ID.Text))
                flag = false;

            textBox_SearchedName.Enabled = flag;
            textBox_MinPages.Enabled = flag;
            textBox_MaxPages.Enabled = flag;
            checkedListBox_GenreSelect.Enabled = flag;
        }

        private void listView_BooksTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_DeleteBook.Enabled = false;
            if (listView_BooksTable.SelectedItems.Count > 0)
            {
                button_DeleteBook.Enabled = true;
                selectedItem = int.Parse(listView_BooksTable.SelectedItems[0].Text);
            }
        }

        private void textBox_MaxPages_TextChanged(object sender, EventArgs e)
        {
            int _minPages = textBox_MinPages.Text != "" ? int.Parse(textBox_MinPages.Text) : 0;
            int _maxPages = 9999;
            // Защита от дурака
            if (!int.TryParse(textBox_MaxPages.Text, out _maxPages) && textBox_MaxPages.Text != "")
            {
                button_FindBook.Enabled = false;
                errorProvider_Pages.SetError(textBox_MaxPages, "Вы пытаетесь ввести что-то кроме чисел!");
            }
            else if (_maxPages < _minPages)
            {
                button_FindBook.Enabled = false;
                errorProvider_Pages.SetError(textBox_MaxPages, "Значение максимального количества страниц меньше минимального количеств страниц");
            }
            else
            {
                button_FindBook.Enabled = true;
                errorProvider_Pages.Clear();
            }
        }

        private void textBox_MinPages_TextChanged(object sender, EventArgs e)
        {
            int _minPages = 0;
            int _maxPages = textBox_MaxPages.Text != "" ? int.Parse(textBox_MaxPages.Text) : 9999;
            if (!int.TryParse(textBox_MinPages.Text, out _minPages) && textBox_MinPages.Text != "")
            {
                button_FindBook.Enabled = false;
                errorProvider_Pages.SetError(textBox_MinPages, "Вы пытаетесь ввести что-то кроме чисел!");
            }
            else if (_maxPages < _minPages)
            {
                button_FindBook.Enabled = false;
                errorProvider_Pages.SetError(textBox_MinPages, "Значение минимального количества страниц больше максимального количеств страниц");
            }
            else
            {
                button_FindBook.Enabled = true;
                errorProvider_Pages.Clear();
            }
        }

        private void button_SaveEdits_Click(object sender, EventArgs e)
        {
            using (var outputFile = new StreamWriter("../../../Data/Books.txt"))
                booksDatabase.SaveInFile(outputFile);
        }

        private void listView_BooksTable_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 1)
            {
                booksDatabase.Database.Sort(new LiteratureNameComparer());
                FillTheTable(booksDatabase);
            }
        }
    }
}

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
    delegate void LoadDatabase(string[] _delimiters, StreamReader inputFile);
    public partial class BookLendersForm : Form
    {
        BooksDatabase? booksDatabase = new BooksDatabase();
        ReadersList readersList = new ReadersList();
        string[] _delimiters = { "    ", " " };
        LoadDatabase loadDatabase;

        public BookLendersForm()
        {
            InitializeComponent();

            loadDatabase = booksDatabase.LoadFromFile;
            using (var inputFile = new StreamReader(@"../../../Data/Books.txt"))
            {
                loadDatabase(_delimiters, inputFile);
            }
            loadDatabase = readersList.LoadFromFile;
            using (var inputFile = new StreamReader(@"../../../Data/Readers.txt"))
            {
                loadDatabase(_delimiters, inputFile);
            }
            readersList.LinkBooksAndReaders(booksDatabase);
            
            // По идее, так мы должны будем избавиться от не нужного более booksDatabase
            booksDatabase = null;

            FillTheTable(readersList);
        }

        private void FillColumns()
        {
            listView_Lenders.Columns.Add(LenderID);
            listView_Lenders.Columns.Add(LenderName);
            listView_Lenders.Columns.Add(BookName);
        }

        private void FillTheTable(ReadersList readersList)
        {
            listView_Lenders.Clear();
            int row_num = 0;
            FillColumns();

            foreach (var reader in readersList.Database) // Ключевое слово var указывает, что компилятор должен вывести тип переменной из выражения справа
            {
                listView_Lenders.Items.Add(reader.Id.ToString());
                listView_Lenders.Items[row_num].SubItems.Add(reader.Name);
                if (reader.Book != null)
                    listView_Lenders.Items[row_num].SubItems.Add(reader.Book.Name);
                row_num++;
            }
        }

        private void listView_Lenders_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 1)
            {
                readersList.Database.Sort(new ReaderNameComparer());
                FillTheTable(readersList);
            }
        }
    }
}

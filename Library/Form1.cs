namespace Library
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button_ShowBooksTable_Click(object sender, EventArgs e)
        {
            var booksTable = new BooksTable();
            booksTable.Show();
        }

        private void button_ShowLendersTable_Click(object sender, EventArgs e)
        {
            var bookLendersForm = new BookLendersForm();
            bookLendersForm.Show();
        }
    }
}
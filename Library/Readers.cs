using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Readers
    {
        int _id;
        string _name;
        int _lendedBook;
        Literature _book;

        // Если читатель не брал книгу, у него lendedBook == -1
        public Readers(int id, string name, int lendedBook = -1)
        {
            _id = id;
            _name = name;
            _lendedBook = lendedBook;
        }

        public int Id { get => _id; }
        public string Name { get => _name; }
        internal int LendedBook { get => _lendedBook; }
        internal Literature Book { get => _book; set => _book = value; }

        internal string ShowReport() => $"{Id} {Name.Replace(' ', '_')} {LendedBook}";
    }

    internal class ReadersList : IDatabase
    {
        List<Readers> _database = new List<Readers>();

        internal List<Readers> Database { get => _database; }

        public void Add(object newReader) => _database.Add((Readers) newReader);
        public void Add(object[] newReaders)
        {
            foreach (Readers item in newReaders)
                _database.Add(item);
        }

        public void LoadFromFile(string[] delimiters, StreamReader inputFile)
        {
            string _anotherLine = inputFile.ReadLine();

            while (!string.IsNullOrWhiteSpace(_anotherLine))
            {
                string[] inputLine = _anotherLine.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                var anotherReader = new Readers(int.Parse(inputLine[0]), inputLine[1].Replace('_', ' '), int.Parse(inputLine[2]));
                _database.Add(anotherReader);
                _anotherLine = inputFile.ReadLine();
            }
        }

        public void Remove(int id)
        {
            _database.RemoveAt(id);
        }

        public void SaveInFile(StreamWriter outputFile)
        {
            foreach (Readers reader in _database)
            {
                outputFile.WriteLine(reader.ShowReport());
            }
        }

        public void LinkBooksAndReaders(BooksDatabase books)
        {
            foreach (var reader in _database)
            {
                if (reader.LendedBook == -1) continue;
                reader.Book = books.FindById(reader.LendedBook);
            }
        }
    }

    class ReaderIDComparer : IComparer<Readers>
    {
        public int Compare(Readers? x, Readers? y)
        {
            return x.Id - y.Id;
        }
    }
    // Применение: перейди по ссылке
    class ReaderNameComparer : IComparer<Readers>
    {
        public int Compare(Readers? x, Readers? y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}

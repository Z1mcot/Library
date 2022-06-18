using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Literature
    {
        private int _id;
        private string _name;
        private string _genre;
        private int _pagesCount;

        protected Literature(int id, string name, string genre, int pagesCount)
        {
            _id = id;
            _name = name;
            _genre = genre;
            _pagesCount = pagesCount;
        }

        public int Id { get => _id; }
        public string Name { get => _name; }
        public string Genre { get => _genre; }
        public int PagesCount { get => _pagesCount; }

        public abstract string ShowReport();
    }

    internal class Book : Literature
    {
        private int _yearOfPublishment;
        public Book(int id, string name, string genre, int pagesCount, int yearOfPublishment) : base(id, name, genre, pagesCount)
        {
            _yearOfPublishment = yearOfPublishment;
        }

        public int YearOfPublishment { get => _yearOfPublishment; }

        public override string ShowReport() => $"Книга {Id} {Name.Replace(' ', '_')} {Genre} {PagesCount} {YearOfPublishment}";
        
    }

    internal class NewsIssue : Literature
    {
        private int _issueNumber;

        public NewsIssue(int id, string name, string genre, int pagesCount, int issueNumber) : base(id, name, genre, pagesCount)
        {
            _issueNumber = issueNumber;
        }

        public int IssueNumber { get => _issueNumber; }

        public override string ShowReport() => $"Газета {Id} {Name.Replace(' ', '_')} {Genre} {PagesCount} {IssueNumber}";
    }

    public class BooksDatabase : IDatabase
    {
        private ArrayList _database = new ArrayList() { };

        public ArrayList Database { get => _database; }

        public void Add(object newLiteraturePiece) => _database.Add((Literature)newLiteraturePiece);
        public void Add(object[] newLiteraturePieces)
        {
            foreach (Literature item in newLiteraturePieces)
                _database.Add(item);
        }

        /// <summary>
        /// Фильтрация книг по заданным жанрам.
        /// </summary>
        /// <param name="genres">Список жанров, по которым происходит отбор</param>
        /// <returns>BooksDatabse с книгами с нужными жанрами</returns>
        public BooksDatabase FindByGenre(List<string> genres)
        {
            var result = new BooksDatabase { };

            foreach (var entry in _database)
            {
                var book = (Literature)entry;
                if (genres.Contains(book.Genre))
                {
                    result.Add(book);
                }
            }
            return result;
        }

        // т.к. id однозначно определяет книгу, то на выходе у нас одна единственная книга (или ни одной)
        public Literature? FindById(int id)
        {
            foreach (var entry in _database)
            {
                var book = (Literature)entry;
                if (book.Id == id) return book;
            }
            return null;
        }

        public BooksDatabase FindByName(string name)
        {
            var result = new BooksDatabase { };

            foreach (var entry in _database)
            {
                var book = (Literature)entry;
                if (book.Name == name)
                {
                    result.Add(book);
                }
            }

            return result;
        }

        public BooksDatabase FindByPages(int minPagesCount, int maxPagesCount)
        {
            var result = new BooksDatabase { };

            foreach (var entry in _database)
            {
                var book = (Literature)entry;
                if (book.PagesCount >= minPagesCount && book.PagesCount <= maxPagesCount)
                {
                    result.Add(book);
                }
            }
            return result;
        }
        public void Remove(int id) => _database.RemoveAt(id);

        public void LoadFromFile(string[] delimiters, StreamReader inputFile)
        {
            string _anotherLine = inputFile.ReadLine();
            // Пока очередная считаная строка — не пустая, продолжаем загружать в БД новые объекты
            while (!string.IsNullOrWhiteSpace(_anotherLine))
            {
                string[] inputLine = _anotherLine.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                var anotherItem = GetType(inputLine); // У нас в одном файле могут быть объекты разных классов (это для ArrayList)
                _database.Add(anotherItem);
                _anotherLine = inputFile.ReadLine();
            }
        }

        private Literature GetType(string[] inputLine)
        {
            if (inputLine[0] == "Книга") 
                return new Book(int.Parse(inputLine[1]), inputLine[2].Replace('_', ' '), inputLine[3], int.Parse(inputLine[4]), int.Parse(inputLine[5]));
            // else — не обязательно в этом случае
            return new NewsIssue(int.Parse(inputLine[1]), inputLine[2], inputLine[3], int.Parse(inputLine[4]), int.Parse(inputLine[5]));
        }

        

        public void SaveInFile(StreamWriter outputFile)
        {
            foreach (Literature item in _database)
            {
                outputFile.WriteLine(item.ShowReport());
            }
        }
    }

    class LiteratureNameComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Literature bookX, bookY;
            bookX = x as Literature;
            bookY = y as Literature;
            return bookX.Name.CompareTo(bookY.Name);
        }
    }
}

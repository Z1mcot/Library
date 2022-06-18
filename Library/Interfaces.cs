using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    // Интерфейс взаимодействия с нашими "базами данных"
    interface IDatabase
    {
        public void Add(object newItem);
        public void Add(object[] newItems);
        public void Remove(int id);
        void LoadFromFile(string[] delimiters, StreamReader inputFile);
        void SaveInFile(StreamWriter outputFile);
    }
}

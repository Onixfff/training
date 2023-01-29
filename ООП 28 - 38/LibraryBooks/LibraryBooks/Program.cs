using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            int userInput;
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Библиотека книг\n1-Добавить книгу\n2-Убрать книгу" +
                    $"\n3-Показать все книги\n4-Показать книгу по указанному параметру");
                if(int.TryParse(Console.ReadLine(),out userInput))
                {
                    switch (userInput)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Добавить книгу");
                            Console.WriteLine("Введите название книги");
                            string nameBook = Console.ReadLine();
                            Console.WriteLine("Введите автора(ов) книги");
                            string author = Console.ReadLine();
                            string userInputDate;
                            DateTime date;
                            do
                            {
                                Console.WriteLine("Введите дату выпуска книги в формате yyyy.mm.dd (год.месяц.день)");
                                userInputDate = Console.ReadLine();
                            }
                            while (!DateTime.TryParseExact(userInputDate,
                            "yyyy.mm.dd", null, System.Globalization.DateTimeStyles.None, out date));
                            {
                                library.AddBook(nameBook, author, date);
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Все книги");
                            library.ShowBook();
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine();
                            break;
                        default:
                            Console.WriteLine("Такой пункт отсутствует");
                            Console.ReadKey();
                            break;
                    }
                }
            }
        }
    }

    class Library
    {
        private List<Book> _books = new List<Book>();

        public void AddBook(string name, string author, DateTime date)
        {
            Book book = new Book(name, author, date);
            _books.Add(book);
        }

        public void ShowBook()
        {
            foreach (Book book in _books)
            {
                book.ShowBook();
            }
        }
    }

    class Book
    {
        private string _name;
        private string _author;
        private DateTime _date;

        public Book(string name, string author, DateTime date)
        {
            _name = name;
            _author = author;
            _date = date;
        }

        public void ShowBook()
        {
            Console.WriteLine($"{_name}\nАвтор(ы) - {_author}\nДата выхода - {_date.ToString("d")}");
        }
    }
}

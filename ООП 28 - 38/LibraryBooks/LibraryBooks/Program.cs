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
            CreateStartBooks randomBooks = new CreateStartBooks();
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
                            while (!DateTime.TryParseExact(userInputDate, "yyyy.MM.dd", null, 
                            System.Globalization.DateTimeStyles.None, out date));
                            {
                                library.AddBook(nameBook, author, date);
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine();
                            Console.ReadKey();
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

    class CreateStartBooks
    {
        private Random _random = new Random();
        private List<Book> _books = new List<Book>();
        private string[] _nameBoks = new string[10] { "Ворон", "Тайные чувства главы корпорации",
            "Сбежать от ректора. Отработка для попаданки", "Тайная дочь от миллиардера. Чужие ошибки", 
            "Босиком по стеклам", "Наказание браком доктора - попаданки", "Хорошая девочка для плохого мальчика",
            "Измена. Жених сестры", "Случайная семья для мажора", "Опер. Реквием по любви" };
        private string[] _authors = new string[10] { "Ольга Грон", "Кария Гросс", "Даша Литовская",
            "Яра Вольцева", "Кристина Юраш", "Елена Безрукова", "Лиза Шимай", "Аниса Таниева", "Ольга Шо",
            "Алсу Караева" };
        private DateTime[] _dates = new DateTime[10] 
        {
            new DateTime(2005, 12, 21),
            new DateTime(2004, 1, 12),
            new DateTime(1988, 11, 04),
            new DateTime(2984, 10, 31),
            new DateTime(2936, 9, 25),
            new DateTime(1958, 8, 22),
            new DateTime(1995, 11, 20),
            new DateTime(1994, 3, 15),
            new DateTime(2021, 4, 19),
            new DateTime(2014, 5, 07),
        };
        
        public CreateStartBooks()
        {
            for(int i = 0; i == 10; i++)
            {
                Book book = new Book(_nameBoks[i],_authors[i],_dates[i]);
                _books.Add(book);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Shop__31
{
    class Program
    {
        static void Main()
        {
            Debug.Fail("Ошибка");
            Seller seller = new Seller(new List<Product> { new Product("Конфета", 2, 40, 1), new Product("Телевизор", 250, 2, 15), new Product("Дом", 2000, 1, 1000), new Product("Окно", 2330, 42, 20) }, 100000);
            Player player = new Player(new List<Product>(), 2);
            while (true)
            {
                int cursorTitle = 24;
                Console.CursorLeft = cursorTitle;
                Console.WriteLine("Меню действий\n");
                Console.Write($"1. Посмотреть товары у продавца\n2. Посмотреть инвентарь\b\nВыбор: ");
                string userInput = Console.ReadLine();
                int numberMenu = CheckInputInt(userInput);
                Console.Clear();
                switch (numberMenu)
                {
                    case 1:
                        Console.CursorLeft = cursorTitle;
                        Console.WriteLine("Инвентарь продавца");
                        seller.ShowItems();
                        Console.Write("Приобрести товар?\n1.Да\n2.Нет\n");
                        userInput = Console.ReadLine();
                        numberMenu = CheckInputInt(userInput);
                        switch (numberMenu)
                        {
                            case 1:
                                //HACK Создать метод для вывода у игроков статы с деньгами и весом.
                                Console.WriteLine($"\nВаши:\n1.Деньги - {player.money}.руб\n2.Вес - {player.maxWeight}/{player.weight}.Кг\n");
                                Console.Write("Выбирите номер товара для покупки: ");
                                userInput = Console.ReadLine();
                                int idItem = CheckInputInt(userInput);
                                bool checkId = seller.CheckIdItem(idItem);
                                idItem -= 1;
                                if(checkId == true)
                                {
                                    Console.Write("Введите кол-во покупаемого товара: ");
                                    userInput = Console.ReadLine();
                                    int quantityBuy = CheckInputInt(userInput);
                                    bool checkQuantity = seller.CheckQuantity(idItem, quantityBuy);
                                    if(checkQuantity == true)
                                    {
                                        if(player.money >= seller.GetCost(idItem) * quantityBuy)
                                        {
                                            Console.WriteLine("Подтверждение покупки\n1.Да\n2.Нет");
                                            userInput = Console.ReadLine();
                                            numberMenu = CheckInputInt(userInput);
                                            switch (numberMenu)
                                            {
                                                case 1:
                                                    //HACK исправить idItem чтобы небыло в basedealer --id.
                                                    //TODO Добавить сравнения чтобы недобавлялись повторки, а прибовлялось кол-во товара.
                                                    //HACK quantityBuy если == 0 то убирать из списка у продавца.
                                                    player.SubtractionMoney(quantityBuy * seller.GetCost(idItem));
                                                    player.AddProduct( new Product(seller.GetName(idItem), seller.GetCost(idItem), quantityBuy, seller.GetWeight(idItem)));
                                                    Console.WriteLine("Покупка произведена");
                                                    break;
                                                case 2:
                                                    Console.WriteLine("Покупка отменена");
                                                    break;
                                                default:
                                                    Console.WriteLine("Такого пункта меню нету");
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Проблема с отплатой вам не хватает денег\nУ вас " + player.money + " а товар стоит "+ seller.GetCost(idItem) * quantityBuy);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Такого кол-ва товара нету в наличии {quantityBuy}/{seller.GetQuantity(idItem)}");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Такой номер не присвоен товару или нету в наличии");
                                }
                                break;
                            case 2:
                                break;
                            default:
                                Console.WriteLine("Такого пункта меню нету");
                                break;
                        }
                        break;
                    case 2:
                        Console.CursorLeft = cursorTitle;
                        Console.WriteLine("Инвентарь персонажа");
                        Console.WriteLine($"Деньги - {player.money}.руб\n" +
                            $"Вес - {player.weight}.Кг");
                        player.ShowItems();
                        break;
                    default:
                        Console.WriteLine("Такого пункта в меню нету");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        static int CheckInputInt(string userInput)
        {
            int number;
            bool check = int.TryParse(userInput, out number);
            if (check == true)
                return number;
            else
                return number = 0;
        }
    }

    class Player : BaseDealer
    {
        //HACK lastid брать из игрока.
        public int maxWeight { get; private set; } = 20;
        public int weight { get; private set; } = 0;
        public Player(List<Product> products, int money) : base(products, money) { }
    }

    class Seller : BaseDealer
    {
        //HACK lastid брать из продавца.
        public Seller(List<Product> products, int money) : base(products, money) { }
    }

    class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Price { get; private set; }
        public int Quantity { get; private set; }
        public int Weight { get; private set; }
        private static int _LastId;

        public Product(string name, int price, int quantity, int weight)
        {
            Id = _LastId ++;
            Name = name;
            Price = price;
            Quantity = quantity;
            Weight = weight;
        }

        public void ShowItem()
        {
            Console.WriteLine($"{++Id} | {Name} | {Quantity}.Шт | {Price}.Руб | {Weight}.Кг\n");
        }

        public bool CheckItem(int id)
        {
            if(Id == id)
                return true;
            return false;
        }
    }
    class BaseDealer
    {
        private List<Product> _products = new List<Product>();
        public int money { get; private set; }
        public BaseDealer(List<Product> products, int money)
        {
            _products = products;
            this.money = money;
        }
        public virtual void ShowItems()
        {
            Console.WriteLine("№| Наименование товара | Кол-во | Цена | Вес |");
            foreach (var product in _products)
            {
                product.ShowItem();
            }
        }
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public int GetCost(int id)
        {
            return _products[id].Price;
        }
        public string GetName(int id)
        {
            return _products[id].Name;
        }
        public int GetWeight(int id)
        {
            return _products[id].Weight;
        }
        public int GetQuantity(int id)
        {
            return _products[id].Quantity;
        }
        public bool CheckIdItem(int id)
        {
            bool check;
            foreach (var product in _products)
            {
                check = product.CheckItem(id);
                if (check == true)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckQuantity(int id, int quantity)
        {
            if (quantity <= _products[id].Quantity && quantity > 0)
                return true;
            return false;
        }
        public void SubtractionMoney(int price)
        {
            money -= price;
        }
    }
}

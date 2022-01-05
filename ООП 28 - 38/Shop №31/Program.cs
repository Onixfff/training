using System;
using System.Collections.Generic;

namespace Shop__31
{
    class Program
    {
        static void Main()
        {
            Seller seller = new Seller();
            Player player = new Player();
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
                        seller.ShowItem();
                        Console.Write("Приобрести товар?\n1.Да\n2.Нет\n");
                        userInput = Console.ReadLine();
                        numberMenu = CheckInputInt(userInput);
                        switch (numberMenu)
                        {
                            case 1:
                                Console.WriteLine($"\nВаши деньги - {player.money}.руб");
                                Console.Write("Выбирите номер товара для покупки: ");
                                userInput = Console.ReadLine();
                                int idItem = CheckInputInt(userInput);
                                bool checkId = seller.CheckIdItem(idItem);
                                if (checkId == true)
                                {
                                    Console.Write("Введите кол-во покупаемого товара: ");
                                    userInput = Console.ReadLine();
                                    int quantityBuy = CheckInputInt(userInput);
                                    bool checkQuantity = seller.CheckQuantity(idItem, quantityBuy);
                                    if (checkQuantity == true)
                                    {
                                        if (player.money >= seller.GetCostProducts(idItem) * quantityBuy)
                                        {
                                            Console.WriteLine("Подтверждение покупки\n1.Да\n2.Нет");
                                            userInput = Console.ReadLine();
                                            numberMenu = CheckInputInt(userInput);
                                            switch (numberMenu)
                                            {
                                                case 1:
                                                    idItem--;
                                                    player.AddProduct(seller.GetNameProducts(idItem), seller.GetCostProducts(idItem), quantityBuy);
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
                                            Console.WriteLine("Проблема с отплатой вам не хватает денег\nУ вас " + player.money + " а товар стоит " + seller.GetCostProducts(idItem) * quantityBuy);
                                        }
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
                        player.ShowItem();
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

    class Player : Exchange
    {
        public int money { get; private set; } = 2000;

    }

    class Seller : Exchange
    {
        public int money { get; private set; } = 500;

        public bool CheckIdItem(int id)
        {
            bool check;
            foreach (var product in products)
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
            if (id == products[--id].Id)
            {
                if (quantity <= products[id].Quantity && quantity != 0)
                    return true;
            }
            return false;
        }

        //public override void ShowItem()
        //{
        //    Console.WriteLine("№| Наименование товара |Кол-во | Цена|");
        //    foreach (var product in products)
        //    {
        //        product.ShowItem();
        //    }
        //}
    }

    class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Price { get; private set; }
        public int Quantity { get; private set; }
        private static int _LastId;

        public Product(string name, int price, int quantity)
        {
            Id = _LastId++;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public void ShowItem()
        {
            Console.WriteLine($"{++Id}|{Name}|{Quantity}.Шт|{Price}.руб|\n");
        }

        public bool CheckItem(int id)
        {
            if (id == Id)
                return true;
            return false;
        }
    }

    abstract class Exchange
    {
        protected List<Product> products;

        public void ShowItem()
        {
            Console.WriteLine("№| Наименование товара |Кол-во | Цена|");
            foreach (var product in products)
            {
                product.ShowItem();
            }
        }

        public void AddProduct(string name, int price, int quantity)
        {
            products.Add(new Product(name, price, quantity));
        }

        public string GetNameProducts(int id)
        {
            return products[id].Name;
        }

        public int GetCostProducts(int id)
        {
            return products[id].Quantity;
        }
    }
}

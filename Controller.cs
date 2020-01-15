using System;
using System.Collections.Generic;
using System.Text;

namespace Distributeur
{
    public class Controller
    {
        private List<Drink> drinks;
        private List<Money> coins;
        public Controller()
        {
            View v = new View();
            //Inventory
            Drink d1 = new Drink("Pepsi", 1.2, 5);
            Drink d2 = new Drink("7Up", 1.2, 5);
            Drink d3 = new Drink("Miranda", 1.2, 5);
            Drink d4 = new Drink("IceTea", 1.0, 5);
            drinks = new List<Drink>();
            drinks.Add(d1);
            drinks.Add(d2);
            drinks.Add(d3);
            drinks.Add(d4);
            //Accepted Money
            Money m1 = new Money("Euros", 0.1);
            Money m2 = new Money("Euros", 0.2);
            Money m3 = new Money("Euros", 0.5);
            Money m4 = new Money("Euros", 1.0);
            Money m5 = new Money("Euros", 2.0);
            coins = new List<Money>();
            coins.Add(m1);
            coins.Add(m2);
            coins.Add(m3);
            coins.Add(m4);
            coins.Add(m5);
            v.DisplayMenu(drinks);
            int choice= Convert.ToInt32(Console.ReadLine());
            double remaining = drinks[choice - 1].Price;
            Console.WriteLine("After Choice Remaining is: " + remaining);
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Drink selected : " + drinks[choice - 1].Name);
                    v.ShowAcceptedMoney();
                    while (remaining > 0) {
                        String s = Console.ReadLine();
                        try
                        {
                            var input = s.Split(' ', 2);
                            double coin = Double.Parse(input[0]);  // Double
                            string currency = input[1];     // Currency
                            Money m = new Money(currency, coin);
                            foreach (Money x in coins)
                            {
                                if (x.Equals(m))
                                    remaining = remaining - x.Value;
                            }
                        }
                        catch (NullReferenceException e1)
                        { Console.WriteLine("Bad Input"); }
                        catch (IndexOutOfRangeException e2) {
                            Console.WriteLine("Bad Input");
                        }
                    }
                    v.ReturnMoney(remaining);
                    drinks[choice - 1].Quantity = drinks[choice - 1].Quantity - 1;
                    v.GiveDrink(drinks[choice - 1]);
                    break;
                case 2:
                    Console.WriteLine("Drink selected : " + drinks[choice - 1].Name);
                    v.ShowAcceptedMoney();
                    while (remaining > 0)
                    {
                        String s = Console.ReadLine();
                        try
                        {
                            var input = s.Split(' ', 2);
                            double coin = Double.Parse(input[0]);  // Double
                            string currency = input[1];     // Currency
                            Money m = new Money(currency, coin);
                            foreach (Money x in coins)
                            {
                                if (x.Equals(m))
                                    remaining = remaining - x.Value;
                            }
                        }
                        catch (NullReferenceException e)
                        { Console.WriteLine("Bad Input"); }
                    }
                        v.ReturnMoney(remaining);
                        drinks[choice - 1].Quantity = drinks[choice - 1].Quantity - 1;
                    if (drinks[choice - 1].Quantity == 0)
                        drinks.RemoveAt(choice - 1);
                        v.GiveDrink(drinks[choice - 1]);
                    break;
                case 3:
                    Console.WriteLine("Drink selected : " + drinks[choice - 1].Name);
                    v.ShowAcceptedMoney();
                    while (remaining > 0)
                    {
                        String s = Console.ReadLine();
                        try
                        {
                            var input = s.Split(' ', 2);
                            double coin = Double.Parse(input[0]);  // Double
                            string currency = input[1];     // Currency
                            Money m = new Money(currency, coin);
                            foreach (Money x in coins)
                            {
                                if (x.Equals(m))
                                    remaining = remaining - x.Value;
                            }
                        }
                        catch (NullReferenceException e)
                        { Console.WriteLine("Bad Input"); }
                    }
                    v.ReturnMoney(remaining);
                        drinks[choice - 1].Quantity = drinks[choice - 1].Quantity - 1;
                        v.GiveDrink(drinks[choice - 1]);
                    break;
                case 4:
                    Console.WriteLine("Drink selected : " + drinks[choice - 1].Name);
                    v.ShowAcceptedMoney();
                    while (remaining > 0)
                    {
                        String s = Console.ReadLine();
                        try
                        {
                            var input = s.Split(' ', 2);
                            double coin = Double.Parse(input[0]);  // Double
                            string currency = input[1];     // Currency
                            Money m = new Money(currency, coin);
                            foreach (Money x in coins)
                            {
                                if (x.Equals(m))
                                    remaining = remaining - x.Value;
                            }
                        }
                        catch (NullReferenceException e)
                        { Console.WriteLine("Bad Input"); }
                    }
                        v.ReturnMoney(remaining);
                        drinks[choice - 1].Quantity = drinks[choice - 1].Quantity - 1;
                        v.GiveDrink(drinks[choice - 1]);
                    break;
                case 5:
                    Console.WriteLine("Drink selected : " + drinks[choice - 1].Name);
                    v.ShowAcceptedMoney();
                    while (remaining > 0)
                    {
                        String s = Console.ReadLine();
                        try
                        {
                            var input = s.Split(' ', 2);
                            double coin = Double.Parse(input[0]);  // Double
                            string currency = input[1];     // Currency
                            Money m = new Money(currency, coin);
                            foreach (Money x in coins)
                            {
                                if (x.Equals(m))
                                    remaining = remaining - x.Value;
                            }
                        }
                        catch (NullReferenceException e)
                        { Console.WriteLine("Bad Input"); }
                    }
                        v.ReturnMoney(remaining);
                        drinks[choice - 1].Quantity = drinks[choice - 1].Quantity - 1;
                        v.GiveDrink(drinks[choice - 1]);
                    
                    break;
                default:
                    Console.WriteLine("Not Found");
                    break;
            }
            v.DisplayMenu(drinks);

        }

    }
}

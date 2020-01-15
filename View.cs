using System;
using System.Collections.Generic;
using System.Text;

namespace Distributeur
{
    public class View
    {
        public void DisplayMenu(List<Drink> drinks)
        {
            Console.WriteLine("Please choose one of the following: ");
            int i = 1;
            foreach (Drink x in drinks)
            {
                Console.WriteLine(""+i+")"+x.ToString());
                i++;
            }
        }
        public void ShowAcceptedMoney() {
            Console.WriteLine("Accepted Coins: 0.1 Euros / 0.2 Euros / 0.5 Euros / 1 Euros / 2 Euros");
        }
        
        public void GiveDrink(Drink d) {
            Console.WriteLine("Don't forget to take your " + d.Name);
        }
        public void ReturnMoney(double remaining)
        {
            while (remaining < 0)
            {
                if (remaining <= -2.0)
                {
                    remaining = remaining + 2.0;
                    Console.WriteLine("Two Euros ejected");
                }
                else if (remaining > -2.0 && remaining <= -1.0)
                {
                    remaining = remaining + 1.0;
                    Console.WriteLine("One Euro ejected");
                }
                else if (remaining > -1.0 && remaining <= -0.5)
                {
                    remaining = remaining + 0.5;
                    Console.WriteLine("0.5 Centimes ejected");
                }
                else if (remaining > -0.5 && remaining <= -0.2)
                {
                    remaining = remaining + 0.2;
                    Console.WriteLine("0.2 Centimes ejected");
                }
                else if (remaining > -0.2 && remaining <= -0.1)
                {
                    remaining = remaining + 0.1;
                    Console.WriteLine("0.1 Centimes ejected");
                }
                else
                    remaining = 0.0;
            }

        }
    }
}

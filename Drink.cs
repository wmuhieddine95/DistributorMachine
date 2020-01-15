using System;
using System.Collections.Generic;
using System.Text;

namespace Distributeur
{
    public class Drink
    {
        private String name;
        private double price;
        private int quantity;
        public String Name { set; get; }
        public double Price { set; get; }
        public int Quantity { set; get; }
        
        public override String ToString()
        {
            return ""+this.Name+" price is "+Price+" of quantity "+ this.Quantity;
        }

        public Drink(String name, double price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

    }
}

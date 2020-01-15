using System;
using System.Collections.Generic;
using System.Text;


namespace Distributeur
{
    public class Money
    {
        private String currency;
        private double value;
        public String Currency { set; get; }
        public double Value{ set; get; }
        public override string ToString()
        {
            return "" + this.Value + " " + Currency;
        }

        public Money(String currency, double value)
        {
            this.Currency = currency;
            this.Value = value;
        }
        public bool Equals(Money other)
        {
            if (this.Value == other.Value)
                if (this.Currency == other.Currency)
                    return true;
                else
                    return false;
            else
                return false;
        }
        

    }
}

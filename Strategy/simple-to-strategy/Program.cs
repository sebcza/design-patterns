using System;

namespace simple_to_strategy
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Tax
    {
        public decimal Count(decimal netto, string countryCode)
        {
            if (countryCode == "PL")
            {
                return Decimal.Multiply(netto, 0.23m);
            }
            else if (countryCode == "DE")
            {
                return Decimal.Multiply(netto, 0.3m);
            }
            else if (countryCode == "EN")
            {
                return Decimal.Multiply(netto, 0.15m);
            }

            return 0;
            
            
        }
    }
}

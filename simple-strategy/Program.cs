using System;

namespace simple_strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var contex = new TaxContex();
            contex.SetCountry("DE");
            var tax = contex.CountryTax.Count(123);

        }
    }

    interface ITax
    {
        decimal Count(decimal netto);
    }

    class TaxPL :ITax
    {
        public decimal Count(decimal netto)
        {
            return Decimal.Multiply(netto, 0.23m);
        }
    }
    class TaxDE : ITax
    {
        public decimal Count(decimal netto)
        {
            return Decimal.Multiply(netto, 0.3m);
        }
    }
    class TaxEN : ITax
    {
        public decimal Count(decimal netto)
        {
            return Decimal.Multiply(netto, 0.15m);
        }
    }

    class TaxContex
    {
        private ITax _strategy;

        public ITax CountryTax
        {
            get { return _strategy; }
            private set { _strategy = value; }
        }

        public void SetCountry(string country)
        {
            if (country=="PL")
            {
                _strategy = new TaxPL();
            }
            else if (country == "EN")
            {
                _strategy=new TaxEN();
            }
        }

    }


}

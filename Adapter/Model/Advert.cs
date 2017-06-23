using System;

namespace SampleAdapter.Model
{
    public class Advert
    {
        public virtual string Title { get; set; }
        public virtual int YearOfProduction { get; set; }
        public virtual int Mileage { get; set; }
        public virtual string Description { get; set; }
        public virtual Boolean IsDamaged { get; set; }
        public virtual decimal Price { get; set; }
        public virtual decimal PriceExTax { get; set; }
        public virtual int AuthorId { get; set; }

        public override string ToString()
        {
            return "Title: " + Title + ", Price: " + Price;
        }
    }
}
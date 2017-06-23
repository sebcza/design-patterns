using System;
using SampleAdapter.Model;

namespace SampleAdapter.Repository
{
    public interface IAdvertRepository
    {
        void Insert(Advert advert);
    }

    public class AdvertRepository : IAdvertRepository
    {
        public void Insert(Advert advert)
        {
            Console.WriteLine("Zapisałem: ");
            Console.WriteLine(advert);
        }
    }
}

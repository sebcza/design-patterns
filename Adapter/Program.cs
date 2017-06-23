using System;
using Newtonsoft.Json;
using SampleAdapter.Adapter;
using SampleAdapter.JsonModel;
using SampleAdapter.Repository;
using SampleAdapter.Service;
using SampleAdapter.ViewModel;

namespace SampleAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new AdvertRepository();
            var service = new AdvertService(repository);
            var viewModel = new AdvertViewModel
            {
                Description = "Test",
                IsDamaged = false,
                Mileage = 201233,
                Price = 20000,
                Title = "Super Mazda",
                YearOfProduction = 2006
            };
            service.AddNewAdvert(new AdvertAdapterForm(viewModel));

            var jsonTxt = @"{ 'titleAdd': 'Some title', 'productionYear': 2012, 'distance': 210000, 'description': 'Some text to test', 'priceExTax': 12000, 'isDamage': true }";
            var dataFromJson = JsonConvert.DeserializeObject<AdvertCompanyNameJson>(jsonTxt);
            service.AddNewAdvert(new AdvertAdapterCompanyName(dataFromJson));

            
            Console.ReadKey();
        }
    }
}

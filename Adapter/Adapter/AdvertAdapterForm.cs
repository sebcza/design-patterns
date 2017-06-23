using SampleAdapter.Model;
using SampleAdapter.ViewModel;

namespace SampleAdapter.Adapter
{
    public class AdvertAdapterForm : Advert
    {
        private readonly AdvertViewModel _advertViewModel;

        public AdvertAdapterForm(AdvertViewModel advertViewModel)
        {
            _advertViewModel = advertViewModel;
        }

        public override int AuthorId
        {
            get { return 12; }
        } //Current logged user

        public override string Description { get { return _advertViewModel.Description; } }

        public override int Mileage { get { return _advertViewModel.Mileage; } }

        public override int YearOfProduction { get { return _advertViewModel.YearOfProduction; } }

        public override bool IsDamaged { get { return _advertViewModel.IsDamaged; } }

        public override decimal Price { get { return _advertViewModel.Price; } }

        public override decimal PriceExTax { get { return decimal.Divide(_advertViewModel.Price, (decimal)1.23); } }

        public override string Title { get { return _advertViewModel.Title; } }
    }
}
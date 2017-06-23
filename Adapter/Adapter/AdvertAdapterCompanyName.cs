using SampleAdapter.JsonModel;
using SampleAdapter.Model;

namespace SampleAdapter.Adapter
{
    public class AdvertAdapterCompanyName : Advert
    {
        private readonly AdvertCompanyNameJson _companyNameJson;

        public AdvertAdapterCompanyName(AdvertCompanyNameJson companyNameJson)
        {
            _companyNameJson = companyNameJson;
        }

        private const int CompanyNameUserId = 678;

        public override int AuthorId { get { return CompanyNameUserId; } }

        public override string Description { get { return _companyNameJson.description; } }

        public override bool IsDamaged { get { return _companyNameJson.isDamage; } }

        public override int Mileage { get { return _companyNameJson.distance; } }

        public override decimal Price { get { return decimal.Multiply(_companyNameJson.priceExTax, (decimal)1.23); } }

        public override decimal PriceExTax { get { return _companyNameJson.priceExTax; } }

        public override string Title { get { return _companyNameJson.titleAdd; } }

        public override int YearOfProduction { get { return _companyNameJson.productionYear; } }
    }
}
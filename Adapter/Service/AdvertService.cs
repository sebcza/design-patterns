using SampleAdapter.Model;
using SampleAdapter.Repository;

namespace SampleAdapter.Service
{
    public class AdvertService : IAdvertService
    {
        private readonly IAdvertRepository _advertRepository;

        public AdvertService(IAdvertRepository advertRepository)
        {
            _advertRepository = advertRepository;
        }

        public void AddNewAdvert(Advert advert)
        {
            _advertRepository.Insert(advert);

        }
    }

    public interface IAdvertService
    {
        void AddNewAdvert(Advert advert);
    }
}

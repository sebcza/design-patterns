using System;
using observer_pattern_sample.Model;

namespace observer_pattern_sample
{
    public class TemperatureSensor : IObservable<TemperatureSnippet>
    {
        public IDisposable Subscribe(IObserver<TemperatureSnippet> observer)
        {
            throw new NotImplementedException();
        }
    }
}

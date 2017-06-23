using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using observer_pattern_sample.Model;

namespace observer_pattern_sample
{
    public class DatabaseWriter : IObserver<TemperatureSnippet>
    {
        public void OnNext(TemperatureSnippet value)
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }
    }
}

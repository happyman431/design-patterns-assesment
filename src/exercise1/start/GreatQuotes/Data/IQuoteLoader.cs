using GreatQuotes.ViewModels;
using System.Collections.Generic;

namespace GreatQuotes.Data
{
    public interface IQuoteLoader
    {
        IEnumerable<GreatQuoteViewModel> Load();
        void Save(IEnumerable<GreatQuoteViewModel> quotes);
    }
}
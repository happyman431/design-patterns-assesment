using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using GreatQuotes.Data;
using GreatQuotes.ViewModels;

namespace GreatQuotes.iOS {
    public interface IQouteLoader
    {
        IEnumerable<GreatQuoteViewModel> Load();
        void Save(IEnumerable<GreatQuoteViewModel> quotes);
    }
}
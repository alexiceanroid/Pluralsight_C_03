using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMinisterLibrary
{
    class PrimeMinisterByYearDictionary : KeyedCollection<int, PrimeMinister>
    {
        protected override int GetKeyForItem(PrimeMinister item)
        {
            return item.YearElected;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreshFish.Tests
{
    class CatchCalculator
    {
        public int SumCatchValue(int codPricePerKg, int octopusPricePerKg, int crabPricePerKg)
        {
            return 50 * codPricePerKg + 100 * octopusPricePerKg + 50 * crabPricePerKg;
        }
    }
}

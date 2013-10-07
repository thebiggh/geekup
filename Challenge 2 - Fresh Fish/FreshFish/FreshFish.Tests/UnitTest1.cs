using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FreshFish.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CostOfPetrolToNottionghamSHouldEqual1600()
        {
            var calculator = new DistanceCalculator();
            Assert.AreEqual(1600, calculator.GetPrice(800));
        }

        [TestMethod] 
        public void CostOfPetrolToGlasgowSHouldEqual2200()
        {
            var calculator = new DistanceCalculator();
            Assert.AreEqual(2200, calculator.GetPrice(1100));
        }

        [TestMethod]
        public void CostOfPetrolToLeedsSHouldEqual1200()
        {
            var calculator = new DistanceCalculator();
            Assert.AreEqual(1200, calculator.GetPrice(600));
        }
    }

    [TestClass]
    public class GivenCod
    {
        [TestMethod]
        public void DegradeCostToNottingham()
        {
            var DissToNotts = 800;

            var result = DegradationCalculator(DissToNotts);

            Assert.IsTrue(result == 8);
        }

        [TestMethod]
        public void DegradeCostToGlasgow()
        {
            var DissToGlasgow = 1100;

            var result = DegradationCalculator(DissToGlasgow);

            Assert.IsTrue(result == 11);
        }

        [TestMethod]
        public void DegradeCostToLeeds()
        {
            var DissToLeeds = 600;

            var result = DegradationCalculator(DissToLeeds);

            Assert.IsTrue(result == 6);
        }

        private int DegradationCalculator(int i)
        {
            return i/100;
        }
    }

    [TestClass]
    public class TotalPriceForCatch
    {
        [TestMethod]
        public void TheTotalPriceForNottinghamShouldBeEqualTo47500()
        {
            var calculator = new CatchCalculator();
            Assert.AreEqual(47500, calculator.SumCatchValue(500, 0, 450));
        }

        [TestMethod]
        public void TheTotalPriceForGlasgowShouldBeEqualTo28500()
        {
            var calculator = new CatchCalculator();
            Assert.AreEqual(2850, calculator.SumCatchValue(450, 120, 0));
        }
    }
}

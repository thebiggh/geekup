// -----------------------------------------------------------------------
// <copyright file="RomanTests.cs" company="Red Box Recorders Ltd">
//     Copyright © Red Box Recorders 2013
// </copyright>
// -----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Roman
{
    [TestFixture]
    class RomanTests
    {
        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        [TestCase("VI", 6)]
        [TestCase("IX", 9)]
        [TestCase("X", 10)]
        [TestCase("XIV", 14)]
        [TestCase("XV", 15)]
        [TestCase("XVIII", 18)]
        [TestCase("XIX", 19)]
        [TestCase("XX", 20)]
        [TestCase("XL", 40)]
        [TestCase("L", 50)]
        [TestCase("XC", 90)]
        [TestCase("C", 100)]
        [TestCase("CD", 400)]
        [TestCase("D", 500)]
        [TestCase("CM", 900)]
        [TestCase("M", 1000)]
        [TestCase("LXXIV", 74)]
        [TestCase("MMXIII", 2013)]
        public void ConvertsToIntegerCorrectly(string roman, int expectedInt)
        {
            var romanNumber = new RomanNumber(roman);
  
            Assert.AreEqual(expectedInt, romanNumber.ToInt());
        }

        [TestCase("I", "I", "II")]
        [TestCase("I", "II", "III")]
        [TestCase("I", "IV", "V")]
        [TestCase("I", "V", "VI")]
        [TestCase("III", "III", "VI")]
        [TestCase("V", "V", "X")]
        [TestCase("I", "III", "IV")]
        public void ConvertsToRomanCorrectly(string lhs, string rhs, string expectedRoman)
        {
            var lhsRoman = new RomanNumber(lhs);
            var rhsRoman = new RomanNumber(rhs);

            var result = lhsRoman.Add(rhsRoman);
            Assert.AreEqual(result, expectedRoman);
        }
    }

    internal class RomanNumber
    {
        private string romanNumeral;

        public RomanNumber(string romanNumeral)
        {
            this.romanNumeral = romanNumeral;
        }

        public int ToInt()
        {
            this.romanNumeral = this.romanNumeral.Replace("CM", "DCD");
            this.romanNumeral = this.romanNumeral.Replace("M", "DD");
            this.romanNumeral = this.romanNumeral.Replace("XC", "XXXXXXXXX");
            this.romanNumeral = this.romanNumeral.Replace("CD", "CCCC");
            this.romanNumeral = this.romanNumeral.Replace("D", "CCCCC");
            this.romanNumeral = this.romanNumeral.Replace("C", "XXXXXXXXXX");
            this.romanNumeral = this.romanNumeral.Replace("XL", "XXXX");
            this.romanNumeral = this.romanNumeral.Replace("L", "XXXXX");
            this.romanNumeral = this.romanNumeral.Replace("IX", "IVV");
            this.romanNumeral = this.romanNumeral.Replace("IV", "IIII");
            this.romanNumeral = this.romanNumeral.Replace("X", "VV");
            this.romanNumeral = this.romanNumeral.Replace("V", "IIIII");

            return this.romanNumeral.Length;
        }

        public string Add(RomanNumber rhs)
        {
            var thisInt = this.ToInt();
            var otherInt = rhs.ToInt();

            int result = thisInt + otherInt;
            string resStr = "";

            resStr += this.AddDivisor(10, 'X', ref result);
            resStr += this.AddDivisor(5, 'V', ref result);
            resStr += this.AddDivisor(1, 'I', ref result);

            resStr = resStr.Replace("IIII", "IV");
            return resStr;
        }

        private string AddDivisor(int divisor, char numeral, ref int result)
        {
            int numberOfVs = result / divisor;
            string resStr = new string(numeral, numberOfVs);
            result -= numberOfVs * divisor;

            return resStr;
        }

        public override string ToString()
        {
            return this.romanNumeral;
        }
    }
}

using NUnit.Framework;
using System;
using UnitTestTask.Models;

namespace UnitTestTask.Test.Tests
{
    [TestFixture]
    public class ClientTests
    {
        [TestCase("Ana", 1990, 10)]
        public void CountDiscountBigLoyality_Test(string name, int birthYear, int yearsOfLoyality)
        {
            var client = new Client()
            {
                Name = name,
                BirthYear = birthYear,
                YearsOfLoyalty = yearsOfLoyality
            };

            var actualDiscount = client.CountDiscount();

            Assert.AreEqual(40, actualDiscount);
        }

        [TestCase("Ana", 2001, 2)]
        public void CountDiscountSmallLoyality_Test(string name, int birthYear, int yearsOfLoyality)
        {
            var client = new Client()
            {
                Name = name,
                BirthYear = birthYear,
                YearsOfLoyalty = yearsOfLoyality
            };

            var actualDiscount = client.CountDiscount();

            Assert.AreEqual(17, actualDiscount);
        }

        [TestCase("Ana")]
        public void CountDiscount_WithoutBirthYear_Test(string name, int yearsOfLoyality)
        {
            var client = new Client()
            { 
                Name = name,
                YearsOfLoyalty = yearsOfLoyality
            };
            var actualDiscount = client.CountDiscount();

            Assert.AreEqual(0, actualDiscount);
        }
    }
}

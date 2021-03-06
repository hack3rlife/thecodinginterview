﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.algorithms.searching.test
{
    [TestClass]
    public class CountOccurrencesTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [TestCategory("BinarySearch")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\binary_search_count.csv", "binary_search_count#csv", DataAccessMethod.Sequential)]
        public void BinarySearch_CountOccurrences_Test()
        {
            // arrange
            var input = TestContext.DataRow[0].ToString().Split(new char[] { ' ' });
            var k = (int)TestContext.DataRow[1];
            var expected = (int)TestContext.DataRow[2];

            // act
            var actual = BinarySearch.Count(Array.ConvertAll(input, s => int.Parse(s)), k);

            // assert
            Assert.AreEqual<int>(expected, actual);
        }
    }
}

﻿using com.hack3rlife.dynamicprogramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LongestCommonSubstringTest
{
    [TestClass]
    public class LongestCommonSubstringTest
    {
        [TestMethod]
        public void LongestCommonSubstring_GetLengthTest()
        {
            //arrange
            string input1 = "OldSite:GeeksforGeeks.org";
            string input2 = "NewSite:GeeksQuiz.com";

            int expected = 10;

            //act
            int actual = LongestCommonSubstring.GetLength(input1.ToLowerInvariant(), input2.ToLowerInvariant());

            //Test

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LongestCommonSubstring_GetSubstringTest()
        {
            //arrange
            string input1 = "abcdaf";
            string input2 = "zbcdf";

            System.Collections.Generic.List<string> expected = new System.Collections.Generic.List<string> { "bcd", };

            //act
            var actual = LongestCommonSubstring.GetSubstring(input1, input2);

            //Test
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}

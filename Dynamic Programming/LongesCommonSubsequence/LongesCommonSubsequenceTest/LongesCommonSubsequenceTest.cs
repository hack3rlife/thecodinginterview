﻿/*
 * @autor: Some smart guy on internet
 * @date: 21/04/2015
 * @project: LongesCommonSubsequence
 * 
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.dynamicprogramming.test
{
    [TestClass]
    public class LongesCommonSubsequenceTest
    {
        [TestMethod]
        public void LongesCommonSubsequence_GetLengthTest()
        {
            //arrange
            var x = "AGGTAB";
            var y = "GXTXAYB";

            var expected = 4; //GTAB
            //act
            var actual = LongesCommonSubsequence.GetLength(x, y);

            //assert
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void LongesCommonSubsequence_GetLengthTest_AllSame()
        {
            //arrange
            var x = "AAAAAAAAAA";
            var y = "AAAAAAAAAA";

            var expected = 10;
            //act
            var actual = LongesCommonSubsequence.GetLength(x, y);

            //assert
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void LongesCommonSubsequence_GetLengthTest_AllDifferent()
        {
            //arrange
            var x = "abcde";
            var y = "fghij";

            var expected = 0;
            //act
            var actual = LongesCommonSubsequence.GetLength(x, y);

            //assert
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void LongesCommonSubsequence_GetLengthTest_OneMatch()
        {
            //arrange
            var x = "abcde";
            var y = "efghi";

            var expected = 1; //e
            //act
            var actual = LongesCommonSubsequence.GetLength(x, y);

            //assert
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void LongesCommonSubsequence_GetLengthTest_TwoMatch()
        {
            //arrange
            var x = "abcda";
            var y = "afgha";

            var expected = 2; //aa
            //act
            var actual = LongesCommonSubsequence.GetLength(x, y);

            //assert
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void LongesCommonSubsequence_GetLengthTest_StartEnd()
        {
            //arrange
            var x = "abcda";
            var y = "hgfeeabc";

            var expected = 3; //abc
            //act
            var actual = LongesCommonSubsequence.GetLength(x, y);

            //assert
            Assert.AreEqual<int>(expected, actual);
        }
    }
}

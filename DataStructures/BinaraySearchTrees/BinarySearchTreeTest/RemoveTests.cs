﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.datastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace com.hack3rlife.datastructures.test
{
    [TestClass()]
    public class RemoveTest
    {        
        [TestMethod]
        public void BinarySearchTree_RemoveRoot_NoError()
        {
            //arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            //act
            bst.Add(50);
            bst.Add(30);
            bst.Add(20);
            bst.Add(40);
            bst.Add(70);
            bst.Add(60);
            bst.Add(80);
            bst.Display();

            bst.InOrder(bst.Root);
            Debug.WriteLine(string.Empty);

            //assert
            bool actual = bst.Remove(50);
            bool expected = true;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(bst.Count == 6);

            bst.InOrder(bst.Root);
            Debug.WriteLine(string.Empty);
        }

        [TestMethod]
        public void BinarySearchTree_RemoveRightLeaf_NoError()
        {
            //arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            //act
            bst.Add(50);
            bst.Add(30);
            bst.Add(20);
            bst.Add(40);
            bst.Add(70);
            bst.Add(60);
            bst.Add(80);
            bst.Display();

            bst.InOrder(bst.Root);
            Debug.WriteLine(string.Empty);

            //assert
            bool actual = bst.Remove(80);
            bool expected = true;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(bst.Count == 6);

            bst.InOrder(bst.Root);
            Debug.WriteLine(string.Empty);
        }

        [TestMethod]
        public void BinarySearchTree_RemoveLeftLeaf_NoError()
        {
            //arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            //act
            bst.Add(50);
            bst.Add(30);
            bst.Add(20);
            bst.Add(40);
            bst.Add(70);
            bst.Add(60);
            bst.Add(80);
            bst.Display();

            bst.InOrder(bst.Root);
            Debug.WriteLine(string.Empty);

            //assert
            bool actual = bst.Remove(20);
            bool expected = true;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(bst.Count == 6);

            bst.InOrder(bst.Root);
            Debug.WriteLine(string.Empty);
        }

        [TestMethod]
        public void BinarySearchTree_RemoveChild_NoError()
        {
            //arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            //act
            bst.Add(50);
            bst.Add(30);
            bst.Add(20);
            bst.Add(70);
            bst.Add(60);
            bst.Add(80);
            bst.Add(10);
            bst.Add(0);

            bst.Display();

            bst.InOrder(bst.Root);
            Debug.WriteLine(string.Empty);

            //assert
            bool actual = bst.Remove(20);
            bool expected = true;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(bst.Count == 7);

            bst.InOrder(bst.Root);
            Debug.WriteLine(string.Empty);
        }

        [TestMethod]
        public void BinarySearchTree_RemoveRoot_Error()
        {
            //arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            //act
            bst.Add(50);
            bst.Add(30);
            bst.Add(20);
            bst.Add(40);
            bst.Add(70);
            bst.Add(60);
            bst.Add(80);
            bst.Display();

            bst.InOrder(bst.Root);
            Debug.WriteLine(string.Empty);

            //assert
            bool actual = bst.Remove(10);
            bool expected = false;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(bst.Count == 7);

            bst.InOrder(bst.Root);
            Debug.WriteLine(string.Empty);
        }
    }
}
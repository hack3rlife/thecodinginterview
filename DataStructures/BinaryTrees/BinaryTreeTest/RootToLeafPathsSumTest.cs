﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.datastructures.test
{
    [TestClass]
    public class RootToLeafPathsSumTest
    {
        [TestMethod]
        [TestCategory("BinaryTree")]
        public void BinaryTree_RootToLeafPathsSum_Test()
        {
            //arrange
            BinaryTree<int> tree = new BinaryTree<int>();

            tree.Root = new BinaryTreeNode<int>(6);
            tree.Root.Left = new BinaryTreeNode<int>(3);
            tree.Root.Left.Left = new BinaryTreeNode<int>(2);
            tree.Root.Left.Right = new BinaryTreeNode<int>(5);
            tree.Root.Left.Right.Left = new BinaryTreeNode<int>(7);
            tree.Root.Left.Right.Right = new BinaryTreeNode<int>(4);

            tree.Root.Right = new BinaryTreeNode<int>(5);
            tree.Root.Right.Right = new BinaryTreeNode<int>(4);

            tree.Display(true);

            //act
            int actual = tree.RootToLeafPathsSum(tree.Root, 0);
            int expected = 13997;

            //assert
            Assert.AreEqual<int>(expected, actual);
        }
    }
}

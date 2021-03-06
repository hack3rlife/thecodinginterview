﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.datastructures
{
    [TestClass]
    public class LinkedListBaseTest
    {
        public LinkedList list { get; set; }

        [TestInitialize]
        public void Initialize(){
            list = new LinkedList();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);
            list.AddLast(60);
            list.AddLast(70);
            list.AddLast(80);
            list.AddLast(90);
            list.Display();
        }
    }
}

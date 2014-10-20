using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomLinkedList;

namespace UnitTestLinkedList
{
    [TestClass]
    public class TestDynamicList
    {
        [TestMethod]
        public void TestDynamicListInit()
        {
            var dList = new DynamicList<int>();
            Assert.AreEqual(0, dList.Count, "Initialising fail!");
 
        }

        public void TestDynamicListIndexing()
        {
            var dList = new DynamicList<int>();
            dList.Add(3);
            Assert.AreEqual(dList[0], 3);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexOutOfRange()
        {
            var dList = new DynamicList<int>();
            dList[-1] = 5;
        }

        [TestMethod]
        public void TestAdd()
        {
            var dList = new DynamicList<int>();
            dList.Add(3);
            Assert.AreEqual(dList.IndexOf(3), 0, "Adding an element failed.");
        }

        [TestMethod]
        public void TestRemoveAt()
        {
            var dList = new DynamicList<int>();
            dList.Add(5);
            dList.Add(3);
            dList.RemoveAt(0);
            Assert.AreEqual(dList[0], 3, "RemoveAt method doesn't work correctly.");
        }

        [TestMethod]
        public void TestRemove()
        {
            var dList = new DynamicList<int>();
            dList.Add(5);
            dList.Add(3);
            dList.Remove(3);
            Assert.AreEqual(dList[0], 5, "Remove method doesn't work correctly.");
        }

        [TestMethod]
        public void TestContains()
        {
            var dList = new DynamicList<int>();
            dList.Add(5);
            dList.Add(3);
            dList.Remove(3);
            Assert.AreEqual(dList.Contains(3), false, "Contains method doesn't work correctly.");
        }

    }
}

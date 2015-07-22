namespace CustomLinkedList.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CustomLinkedListTests
    {
        private DynamicList<int> dynamicList;

        [TestInitialize]
        public void InitDynamicList()
        {
            this.dynamicList = new DynamicList<int>();
        }

        [TestMethod]
        public void TestGetterOfIndexer_GetValue_ShouldReturnCorrectValues()
        {
            dynamicList.Add(0);
            dynamicList.Add(1);
            Assert.AreEqual(0, dynamicList[0], "Incorrect value at index.");
            Assert.AreEqual(1, dynamicList[1], "Incorrect value at index.");
        }

        [TestMethod]
        public void TestSetterOfIndexer_SetValue_ShouldSetTheValuesCorrectly()
        {
            dynamicList.Add(0);
            dynamicList.Add(1);
            dynamicList[0] = 1;
            dynamicList[1] = 0;
            Assert.AreEqual(1, dynamicList[0], "Incorrect value at index.");
            Assert.AreEqual(0, dynamicList[1], "Incorrect value at index.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetterOfIndexer_TestWithNegativeIndex_ShouldThrowException()
        {
            var setValue = dynamicList[-1];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSetterOfIndexer_TestWithNegativeIndex_ShouldThrowException()
        {
            dynamicList[-1] = 0;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetterOfIndexer_TestWithIndexBiggerThanCurrentIndex_ShouldThrowException()
        {
            dynamicList.Add(0);
            var setValue = dynamicList[1];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSetterOfIndexer_TestWithIndexBiggerThanCurrentIndex_ShouldThrowException()
        {
            dynamicList.Add(0);
            dynamicList[1] = 1;
        }

        [TestMethod]
        public void TestRemoveAt_RemoveExistingElement_ShouldRemoveElementAndReturnIt()
        {
            dynamicList.Add(5);
            var removedElement = dynamicList.RemoveAt(0);
            Assert.AreEqual(5, removedElement, "Wrong element removed.");
            Assert.AreEqual(0, dynamicList.Count, "Element was not removed.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRemoveAt_RemoveElementAtNegativeIndex_ShouldThrowException()
        {
            dynamicList.Add(0);
            dynamicList.RemoveAt(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRemoveAt_RemoveElementAtNonExistingIndex_ShouldThrowException()
        {
            dynamicList.Add(0);
            dynamicList.RemoveAt(1);
        }

        [TestMethod]
        public void TestRemove_RemoveSpecifiedElement_ShouldRemoveElementAndReturnItsIndex()
        {
            dynamicList.Add(5);
            var indexOfRemovedElement = dynamicList.Remove(5);
            Assert.AreEqual(0, indexOfRemovedElement, "Wrong element removed.");
            Assert.AreEqual(0, dynamicList.Count, "Element was not removed.");
        }

        [TestMethod]
        public void TestRemove_RemoveNonExistingElement_ShouldReturnMinusOne()
        {
            dynamicList.Add(5);
            var indexOfRemovedElement = dynamicList.Remove(4);
            Assert.AreEqual(-1, indexOfRemovedElement, "No element was supposed to be removed.");
        }

        [TestMethod]
        public void TestIndexOf_CheckWithExistingElement_ShouldReturnIndexOfElement()
        {
            dynamicList.Add(5);
            var indexOfElement = dynamicList.IndexOf(5);
            Assert.AreEqual(0, indexOfElement, "Wrong index returned.");
        }

        [TestMethod]
        public void TestIndexOf_CheckWithNonExistingElement_ShouldReturnMinusOne()
        {
            dynamicList.Add(5);
            var indexOfElement = dynamicList.IndexOf(4);
            Assert.AreEqual(-1, indexOfElement, "Wrong index returned.");
        }

        [TestMethod]
        public void TestContains_CheckWithExistingElement_ShouldReturnTrue()
        {
            dynamicList.Add(5);
            var containsElement = dynamicList.Contains(5);
            Assert.IsTrue(containsElement, "An element should have been found.");
        }

        [TestMethod]
        public void TestContains_CheckWithNonExistingElement_ShouldReturnFalse()
        {
            dynamicList.Add(5);
            var containsElement = dynamicList.Contains(4);
            Assert.IsFalse(containsElement, "No element should have been found.");
        }
    }
}

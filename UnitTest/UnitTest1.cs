using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnit.Framework;
using P1_CustomList;

namespace UnitTest {
    [TestClass]
    public class UnitTest1 {
        
        public abstract class CustomListFacts<T> {

        }


        /*[TestMethod]
        public void TestMethod1() {
            CustomList<string> test = new CustomList<string>();
            CustomList<string> test2 = new CustomList<string>();
            test.Add("ala");
            test2.AddRange(new string[] { "ala" });
            Assert.AreEqual(test == test2, true);
        }

        [TestMethod]
        public void TestMethod2() {
            CustomList<string> test = new CustomList<string>();
            test.Add("ala");
            test.Add("Piotr");
            test.Add("koñ");
            test.Add("monitor");
            test.Add("komputer");
            
            Assert.AreEqual(test[3], "monitor");
        }

        [TestMethod]
        public void TestMethod3() {
            CustomList<string> test = new CustomList<string>();
            test.Add("ala");
            test.Add("Piotr");
            test.Add("koñ");
            test.Add("monitor");
            test.Add("komputer");

            Assert.AreEqual(test.Contains("test"), false);
        }*/

        /*[TestMethod]
        [DataRow("Piotr",1)]
        [DataRow("Ala",1)]
        public void GetCount_AddItem_IsCorrect(string value, int countOfElements) {
            *//*CustomList<string> customList = new CustomList<string>();
            Assert.AreEqual(customList.Count, 0);
            customList.Add("Piotr");
            customList.Add("Agnieszka");
            Assert.AreEqual(customList.Count, 2);*//*

            CustomList<string> customList = new CustomList<string>();
            customList.Add(value);
            Assert.AreEqual(customList.Count, countOfElements);
        }*/
        
        /*[TestMethod]
        public void GetCount_AddItem_IsNotCorrect() {
            CustomList<int> customList = new CustomList<int>();
            Assert.AreNotEqual(customList.Count, 1);
            customList.Add(12);
            customList.Add(44);
            customList.Add(100);
            Assert.AreNotEqual(customList.Count, 0);
            Assert.AreNotEqual(customList.Count, 4);
            Assert.AreNotEqual(customList.Count, 2);
        }
        
        [TestMethod]
        public void GetCount_AddRange_IsCorrect() {
            CustomList<string> customList = new CustomList<string>();
            string[] array = new string[] { "Polska", "Niemcy", "Rosja", "Ukraina" };
            customList.AddRange(array);
            Assert.AreEqual(customList.Count, 4);
        }

        [TestMethod]
        public void GetCount_AddRange_IsNotCorrect() {
            CustomList<float> customList = new CustomList<float>();
            float[] array = new float[] { 1.44F, .55F, 4.44F, 100.44F, 999.99F };
            customList.AddRange(array);
            Assert.AreNotEqual(customList.Count, 0);
            Assert.AreNotEqual(customList.Count, 6);
            Assert.AreNotEqual(customList.Count, 4);
        }

        [TestMethod]
        public void InsertItem_IsCorrect() {
            CustomList<string> customList = new CustomList<string>();
            string[] array = new string[] { "makaron", "bu³ka", "test", "ANS", "PWSZ" };
            customList.AddRange(array);
            customList.Insert("Piotr", 2);
            Assert.Equals(customList[2], "Piotr");
        }

        [TestMethod]
        public void InsertItem_IsNotCorrect() {
            CustomList<string> customList = new CustomList<string>();
            string[] array = new string[] { "makaron", "bu³ka", "test", "ANS", "PWSZ" };
            customList.AddRange(array);
            customList.Insert("Janusz", 0);
            Assert.AreNotEqual(customList[0], "abcd");
        }

        [TestMethod]
        public void GetCountAfterClear_IsCorrect() {
            CustomList<bool> customList = new CustomList<bool>();
            bool[] array = new bool[] { true, false, false, true, true };
            customList.Clear();
            Assert.AreEqual(customList, 0);
        }

        [TestMethod]
        public void GetCountAfterClear_IsNotCorrect() {
            CustomList<bool> customList = new CustomList<bool>();
            bool[] array = new bool[] { true, false, false, true, true };
            customList.Clear();
            Assert.AreNotEqual(customList, -1);
            Assert.AreNotEqual(customList, 1);
        }

        [TestMethod]
        public void GetCountAfterRemoveElement_IsCorrect() {
            CustomList<string> customList = new CustomList<string>();
            string[] array = new string[] { "Polska", "Niemcy", "Rosja", "Ukraina" };
            customList.RemoveElement("Rosja");
            Assert.AreEqual(customList.Count, 3);
            customList.RemoveElement(null);
            Assert.AreEqual(customList.Count, 3);

        }

        [TestMethod]
        public void GetCountAfterRemoveElement_IsNotCorrect() {

        }

        [TestMethod]
        public void GetCountAfterRemoveAt_IsCorrect() {

        }

        [TestMethod]
        public void GetCountAfterRemoveAt_IsNotCorrect() {

        }

        [TestMethod]
        public void ArrayAfterReverse_IsCorrect() {

        }

        [TestMethod]
        public void ArrayAfterReverse_IsNotCorrect() {

        }

        [TestMethod]
        public void GetContainsElement_IsCorrect() {

        }

        [TestMethod]
        public void GetContainsElement_IsNotCorrect() {

        }

        [TestMethod]
        public void GetIndexOfElement_IsCorrect() {

        }

        [TestMethod]
        public void GetIndexOfElement_IsNotCorrect() {

        }

        [TestMethod]
        public void CompareTwoArrays_AreEquals() {

        }

        [TestMethod]
        public void CompareTwoArrays_AreNotEquals() {

        }*/
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using P1_CustomList;

namespace UnitTest {
    [TestClass]
    public class UnitTest1 {
        
        [TestMethod]
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
        }
    }
}

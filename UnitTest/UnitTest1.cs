using Microsoft.VisualStudio.TestTools.UnitTesting;
using P1_CustomList;

namespace UnitTest {
    [TestClass]
    public class UnitTest1 {
        
        [TestMethod]
        public void TestMethod1() {
            CustomList<string> test = new CustomList<string>();
            CustomList<string> test2 = new CustomList<string>(new string[] { "ala" });
            test.Add("ala");
            Assert.AreEqual(test, test2);
        }
    }
}

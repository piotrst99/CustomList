using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using P1_CustomList;
using System;
using System.Collections;
using System.Collections.Generic;
using UnitTest.TestCase;

namespace UnitTest {
    // https://docs.nunit.org/articles/nunit/writing-tests/attributes/testcase.html
    // https://docs.nunit.org/articles/nunit/writing-tests/attributes/testcasesource.html

    [TestFixture]
    public class CustomListTest {

        [Test]
        [TestCaseSource("AddOneElement")]
        public void GetCount_AddItem_IsCorrect(ITester_AddItem tester) {
            tester.GetCount_AddItem_IsCorrect();
        }

        [Test]
        [TestCaseSource("AddOneElement")]
        public void GetCount_AddItem_IsNotCorrect(ITester_AddItem tester) {
            tester.GetCount_AddItem_IsNotCorrect();
        }

        [Test]
        [TestCaseSource("AddOneElement2")]
        public void Compare_AddItem_IsCorrect(ITester_AddItem tester) {
            tester.Compare_AddItem_IsCorrect();
        }

        [Test]
        [TestCaseSource("AddOneElement3")]
        public void Compare_AddItem_IsNotCorrect(ITester_AddItem tester) {
            tester.Compare_AddItem_IsNotCorrect();
        }

        [Test]
        [TestCaseSource("AddMoreElement")]
        public void GetCount_AddItems_IsCorrect(ITester_AddItems tester) {
            tester.GetCount_AddItems_IsCorrect();
        }

        [Test]
        [TestCaseSource("AddMoreElement")]
        public void GetCount_AddItems_IsNotCorrect(ITester_AddItems tester) {
            tester.GetCount_AddItems_IsNotCorrect();
        }

        [Test]
        [TestCaseSource("InsertElement")]
        public void Compare_Insert_IsCorrect(ITester_Insert tester) {
            tester.Compare_Insert_IsCorrect();
        }

        [Test]
        [TestCaseSource("InsertElement2")]
        public void Compare_Insert_IsNotCorrect(ITester_Insert tester) {
            tester.Compare_Insert_IsNotCorrect();
        }

        [Test]
        [TestCaseSource("ClearArray")]
        public void GetCount_Clear_IsCorrect(ITester_Clear tester) {
            tester.GetCount_Clear_IsCorrect();
        }

        [Test]
        [TestCaseSource("ClearArray")]
        public void GetCount_Clear_IsNotCorrect(ITester_Clear tester) {
            tester.GetCount_Clear_IsNotCorrect();
        }

        [Test]
        [TestCaseSource("RemoveItem")]
        public void GetCount_Remove_IsCorrect(ITester_Remove tester) {
            tester.GetCount_Remove_IsCorrect();
        }
        
        [Test]
        [TestCaseSource("RemoveNullItem")]
        public void GetCount_RemoveNullItem_IsCorrect(ITester_Remove tester) {
            tester.GetCount_Remove_IsCorrect();
        }

        [Test]
        [TestCaseSource("RemoveItem2")]
        public void GetCount_Remove_IsNotCorrect(ITester_Remove tester) {
            tester.GetCount_Remove_IsNotCorrect();
        }

        [Test]
        [TestCaseSource("RemoveItemFromIndex")]
        public void GetCount_RemoveAt_IsCorrect(ITester_Remove tester) {
            tester.GetCount_RemoveAt_IsCorrect();
        }

        [Test]
        [TestCaseSource("RemoveItemFromIndex")]
        public void GetCount_RemoveAt_IsNotCorrect(ITester_Remove tester) {
            tester.GetCount_RemoveAt_IsNotCorrect();
        }

        [Test]
        [TestCaseSource("Reverse")]
        public void Compare_Reverse_IsCorrect(ITester_Reverse tester) {
            tester.Compare_Reverse_IsCorrect();
        }

        [Test]
        [TestCaseSource("Reverse2")]
        public void Compare_Reverse_IsNotCorrect(ITester_Reverse tester) {
            tester.Compare_Reverse_IsNotCorrect();
        }
        
        [Test]
        [TestCaseSource("IndexOf")]
        public void Compare_IndexOf_IsCorrect(ITester_IndexOf tester) {
            tester.Compare_InsertOf_IsCorrect();
        }

        [Test]
        [TestCaseSource("IndexOf")]
        public void Compare_IndexOf_IsNotCorrect(ITester_IndexOf tester) {
            tester.Compare_InsertOf_IsNotCorrect();
        }

        [Test]
        [TestCaseSource("Contains")]
        public void Compare_Contains_IsCorrect(ITester_Contains tester) {
            tester.Compare_Contains_IsCorrect();
        }

        [Test]
        [TestCaseSource("Contains2")]
        public void Compare_Contains_IsNotCorrect(ITester_Contains tester) {
            tester.Compare_Contains_IsNotCorrect();
        }

        public static IEnumerable<ITester_AddItem> AddOneElement() {
            yield return new Tester_AddItem<string>() {
                Items = new string[] { },
                Data = "Piotr",
                ExpectedResult = 1
            };
            yield return new Tester_AddItem<int>() {
                Items = new int[] { 0, 44, 21, 3, 4 },
                Data = 10,
                ExpectedResult = 6
            };
            yield return new Tester_AddItem<bool>() {
                Items = new bool[] { true, false, false },
                Data = false,
                ExpectedResult = 4
            };
            yield return new Tester_AddItem<float>() {
                Items = new float[] { 4.44F, .69F, 10F, 999.99F },
                Data = 100.55F,
                ExpectedResult = 5
            };
            yield return new Tester_AddItem<Point>() {
                Items = new Point[] { new Point { X = 0, Y = 0 }, new Point { X = -1, Y = 1 }, new Point { X = 2, Y = 5 } },
                Data = new Point { X = -10, Y = 100 },
                ExpectedResult = 4
            };
        }

        public static IEnumerable<ITester_AddItem> AddOneElement2() {
            yield return new Tester_AddItem<string>() {
                Items = new string[] { },
                Data = "Piotr",
            };
            yield return new Tester_AddItem<int>() {
                Items = new int[] { 0, 44, 21, 3, 4 },
                Data = 10,
            };
            yield return new Tester_AddItem<bool>() {
                Items = new bool[] { true, false, false },
                Data = false,
            };
            yield return new Tester_AddItem<float>() {
                Items = new float[] { 4.44F, .69F, 10F, 999.99F },
                Data = 100.55F,
            };
            yield return new Tester_AddItem<Point>() {
                Items = new Point[] { new Point { X = 0, Y = 0 }, new Point { X = -1, Y = 1 }, new Point { X = 2, Y = 5 } },
                Data = new Point { X = -10, Y = 100 },
            };
        }

        public static IEnumerable<ITester_AddItem> AddOneElement3() {
            yield return new Tester_AddItem<string>() {
                Items = new string[] { },
                Data = "Piotr",
                ObjectToCheck = "Aneta"
            };
            yield return new Tester_AddItem<int>() {
                Items = new int[] { 0, 44, 21, 3, 4 },
                Data = 10,
                ObjectToCheck = 44
            };
            yield return new Tester_AddItem<bool>() {
                Items = new bool[] { true, false, false },
                Data = false,
                ObjectToCheck = true
            };
            yield return new Tester_AddItem<float>() {
                Items = new float[] { 4.44F, .69F, 10F, 999.99F },
                Data = 100.55F,
                ObjectToCheck = 4.44F
            };
            yield return new Tester_AddItem<Point>() {
                Items = new Point[] { new Point { X = 0, Y = 0 }, new Point { X = -1, Y = 1 }, new Point { X = 2, Y = 5 } },
                Data = new Point { X = -10, Y = 100 },
                ObjectToCheck = null
            };
        }

        public static IEnumerable<ITester_AddItems> AddMoreElement() {
            yield return new Tester_AddItems<string>() {
                Items = new string[] { },
                Datas = new string[] { "Piotr", "Karolina", "Maria", "Rafał" },
                ExpectedResult = 4
            };
            yield return new Tester_AddItems<int>() {
                Items = new int[] { 0, 44, 21, 3, 4 },
                Datas = new int[] { 44, 33, 1, 2, 3, 6, 7 },
                ExpectedResult = 12
            };
            yield return new Tester_AddItems<bool>() {
                Items = new bool[] { },
                Datas = new bool[] { },
                ExpectedResult = 0
            };
            yield return new Tester_AddItems<float>() {
                Items = new float[] { 4.44F, .69F, 10F, 999.99F },
                Datas = new float[] { .0001F, 1000.01F },
                ExpectedResult = 6
            };
            yield return new Tester_AddItems<Point>() {
                Items = new Point[] { new Point { X = 0, Y = 0 }, new Point { X = -1, Y = 1 }, new Point { X = 2, Y = 5 } },
                Datas = new Point[] { new Point { X = -10, Y = 100 }, new Point { X = 30, Y = -11 } },
                ExpectedResult = 5
            };
        }

        public static IEnumerable<ITester_Insert> InsertElement() {
            yield return new Tester_Insert<string>() {
                Items = new string[] { },
                Data = "Karol",
                Position = 0
            };
            yield return new Tester_Insert<int>() {
                Items = new int[] { 0, 44, 21, 3, 4 },
                Data = 69,
                Position = 1
            };
            yield return new Tester_Insert<bool>() {
                Items = new bool[] { true, false, false },
                Data = true,
                Position = 2
            };
            yield return new Tester_Insert<float>() {
                Items = new float[] { 4.44F, .69F, 10F, 999.99F },
                Data = 676.001F,
                Position = 3
            };
            yield return new Tester_Insert<Point>() {
                Items = new Point[] { new Point { X = 0, Y = 0 }, new Point { X = -1, Y = 1 }, new Point { X = 2, Y = 5 } },
                Data = new Point { X = 2, Y = -13 },
                Position = 2
            };
        }

        public static IEnumerable<ITester_Insert> InsertElement2() {
            yield return new Tester_Insert<string>() {
                Items = new string[] { },
                Data = "Karol",
                Position = 0,
                ExpectedResult = "Maria"
            };
            yield return new Tester_Insert<int>() {
                Items = new int[] { 0, 44, 21, 3, 4 },
                Data = 69,
                ExpectedResult = 11
            };
            yield return new Tester_Insert<bool>() {
                Items = new bool[] { true, false, false },
                Data = true,
                ExpectedResult = false
            };
            yield return new Tester_Insert<float>() {
                Items = new float[] { 4.44F, .69F, 10F, 999.99F },
                Data = 676.001F,
                ExpectedResult = .0F
            };
            yield return new Tester_Insert<Point>() {
                Items = new Point[] { new Point { X = 0, Y = 0 }, new Point { X = -1, Y = 1 }, new Point { X = 2, Y = 5 } },
                Data = new Point { X = 2, Y = -13 },
                Position = 2,
                ExpectedResult = new Point { X = 0, Y = 23 }
            };
        }

        public static IEnumerable<ITester_Clear> ClearArray() {
            yield return new Tester_Clear<string>() {
                Items = new string[] { "Piotr", "Danuta" },
            };
            yield return new Tester_Clear<int>() {
                Items = new int[] { 0, 44, 21, 3, 4 },
            };
            yield return new Tester_Clear<bool>() {
                Items = new bool[] { true, false, false },
            };
            yield return new Tester_Clear<float>() {
                Items = new float[] { },
            };
            yield return new Tester_Clear<Point>() {
                Items = new Point[] { new Point { X = 0, Y = 0 }, new Point { X = -1, Y = 1 }, new Point { X = 2, Y = 5 } },
            };
        }

        public static IEnumerable<ITester_Remove> RemoveItem() {
            yield return new Tester_Remove<string>() {
                Items = new string[] { },
                Data = "Karol",
                ExpectionCountOfElement = 0
            };
            yield return new Tester_Remove<int>() {
                Items = new int[] { 0, 44, 21, 3, 4 },
                Data = 69,
                ExpectionCountOfElement = 5
            };
            yield return new Tester_Remove<bool>() {
                Items = new bool[] { true, false, false },
                Data = true,
                ExpectionCountOfElement = 2
            };
            yield return new Tester_Remove<float>() {
                Items = new float[] { 4.44F, .69F, 10F, 999.99F },
                Data = 10F,
                ExpectionCountOfElement = 3
            };
            yield return new Tester_Remove<Point>() {
                Items = new Point[] { new Point { X = 0, Y = 0 }, new Point { X = -1, Y = 1 }, new Point { X = 2, Y = 5 } },
                Data = new Point { X = 0, Y = 0 },
                ExpectionCountOfElement = 2
            };
        }

        public static IEnumerable<ITester_Remove> RemoveItem2() {
            yield return new Tester_Remove<string>() {
                Items = new string[] { "Piotr", "Anna", "Karol" },
                Data = "Karol",
            };
            yield return new Tester_Remove<int>() {
                Items = new int[] { 0, 44, 21, 3, 4 },
                Data = 69,
            };
            yield return new Tester_Remove<bool>() {
                Items = new bool[] { true, false, false },
                Data = true,
            };
            yield return new Tester_Remove<float>() {
                Items = new float[] { 4.44F, .69F, 10F, 999.99F },
                Data = 10F,
            };
            yield return new Tester_Remove<Point>() {
                Items = new Point[] { new Point { X = 0, Y = 0 }, new Point { X = -1, Y = 1 }, new Point { X = 2, Y = 5 } },
                Data = new Point { X = 0, Y = 0 },
            };
        }

        public static IEnumerable<ITester_Remove> RemoveNullItem() {
            yield return new Tester_Remove<string>() {
                Items = new string[] { },
                Data = null,
                ExpectionCountOfElement = 0
            };
            yield return new Tester_Remove<int?>() {
                Items = new int?[] { 0, 44, 21, 3, 4 },
                Data = null,
                ExpectionCountOfElement = 5
            };
            yield return new Tester_Remove<bool?>() {
                Items = new bool?[] { true, false, false },
                Data = null,
                ExpectionCountOfElement = 3
            };
            yield return new Tester_Remove<float?>() {
                Items = new float?[] { 4.44F, .69F, 10F, 999.99F },
                Data = null,
                ExpectionCountOfElement = 4
            };
            yield return new Tester_Remove<Point>() {
                Items = new Point[] { new Point { X = 0, Y = 0 }, new Point { X = -1, Y = 1 }, new Point { X = 2, Y = 5 } },
                Data = null,
                ExpectionCountOfElement = 3
            };
        }

        public static IEnumerable<ITester_Remove> RemoveItemFromIndex() {
            yield return new Tester_Remove<string>() {
                Items = new string[] { },
                Position = 0,
                ExpectionCountOfElement = 0
            };
            yield return new Tester_Remove<int>() {
                Items = new int[] { 0, 44, 21, 3, 4 },
                Position = 5,
                ExpectionCountOfElement = 5
            };
            yield return new Tester_Remove<bool?>() {
                Items = new bool?[] { true, false, false },
                Position = 1,
                ExpectionCountOfElement = 2
            };
            yield return new Tester_Remove<float?>() {
                Items = new float?[] { 4.44F, .69F, 10F, 999.99F },
                Position = 1,
                ExpectionCountOfElement = 3
            };
            yield return new Tester_Remove<Point>() {
                Items = new Point[] { new Point { X = 0, Y = 0 }, new Point { X = -1, Y = 1 }, new Point { X = 2, Y = 5 } },
                Position = 2,
                ExpectionCountOfElement = 2
            };
        }

        public static IEnumerable<ITester_Reverse> Reverse() {
            yield return new Tester_Reverse<string>() {
                Items = new string[] { "Piotr" },
                ExpectionResult = new string[] { "Piotr" }
            };
            yield return new Tester_Reverse<int>() {
                Items = new int[] { 0, 44, 21, 3, 4 },
                ExpectionResult = new int[] { 4, 3, 21, 44, 0 }
            };
            yield return new Tester_Reverse<bool?>() {
                Items = new bool?[] { true, false, false },
                ExpectionResult = new bool?[] { false, false, true }
            };
            yield return new Tester_Reverse<float?>() {
                Items = new float?[] { 4.44F, .69F, 10F, 999.99F },
                ExpectionResult = new float?[] { 999.99F, 10F, .69F, 4.44F }
            };
            yield return new Tester_Reverse<Point>() {
                Items = new Point[] { new Point { X = 0, Y = 0 }, new Point { X = -1, Y = 1 }, new Point { X = 2, Y = 5 } },
                ExpectionResult = new Point[]{ new Point { X = 2, Y = 5 }, new Point { X = -1, Y = 1 }, new Point { X = 0, Y = 0 } }
            };
        }

        public static IEnumerable<ITester_Reverse> Reverse2() {
            yield return new Tester_Reverse<string>() {
                Items = new string[] { "Piotr" },
                ExpectionResult = new string[] { }
            };
            yield return new Tester_Reverse<int>() {
                Items = new int[] { 0, 44, 21, 3, 4 },
                ExpectionResult = new int[] { 0, 44, 21, 3, 4 }
            };
            yield return new Tester_Reverse<bool?>() {
                Items = new bool?[] { true, false, false },
                ExpectionResult = new bool?[] { true, false, false }
            };
            yield return new Tester_Reverse<float?>() {
                Items = new float?[] { 4.44F, .69F, 10F, 999.99F },
                ExpectionResult = new float?[] { 4.44F, .69F, 10F, 999.99F }
            };
            yield return new Tester_Reverse<Point>() {
                Items = new Point[] { new Point { X = 0, Y = 0 }, new Point { X = -1, Y = 1 }, new Point { X = 2, Y = 5 } },
                ExpectionResult = new Point[] { new Point { X = 0, Y = 0 }, new Point { X = -1, Y = 1 }, new Point { X = 2, Y = 5 } }
            };
        }

        public static IEnumerable<ITester_IndexOf> IndexOf() {
            yield return new Tester_IndexOf<string>() {
                Items = new string[] { "Piotr" },
                Item = null,
                ExpectionResult = -1
            };
            yield return new Tester_IndexOf<int>() {
                Items = new int[] { 0, 44, 21, 3, 4 },
                Item = 4,
                ExpectionResult = 4
            };
            yield return new Tester_IndexOf<bool?>() {
                Items = new bool?[] { true, false, false },
                Item = false,
                ExpectionResult = 1
            };
            yield return new Tester_IndexOf<float?>() {
                Items = new float?[] { 4.44F, .69F, 10F, 999.99F },
                Item = 666F,
                ExpectionResult = -1
            };
            yield return new Tester_IndexOf<Point>() {
                Items = new Point[] { new Point { X = 0, Y = 0 }, new Point { X = -1, Y = 1 }, new Point { X = 2, Y = 5 } },
                Item = new Point { X = 0, Y = 0 },
                ExpectionResult = 0
            };
        }

        public static IEnumerable<ITester_Contains> Contains() {
            yield return new Tester_Contains<string>() {
                Items = new string[] { "Piotr", "Rozalia", "Michał" },
                Item = "Rozalia",
                ExpectionResult = true
            };
            yield return new Tester_Contains<int?>() {
                Items = new int?[] { 0, 44, 21, null, 4 },
                Item = null,
                ExpectionResult = true
            };
            yield return new Tester_Contains<bool?>() {
                Items = new bool?[] { true, true, true },
                Item = false,
                ExpectionResult = false
            };
            yield return new Tester_Contains<float?>() {
                Items = new float?[] { 4.44F, .69F, 10F, 999.99F },
                Item = 0F,
                ExpectionResult = false
            };
            yield return new Tester_Contains<Point>() {
                Items = new Point[] { new Point { X = 0, Y = 0 }, new Point { X = -1, Y = 1 }, new Point { X = 2, Y = 5 }, null },
                Item = new Point { X = -1, Y = 1 },
                ExpectionResult = true
            };
        }

        public static IEnumerable<ITester_Contains> Contains2() {
            yield return new Tester_Contains<string>() {
                Items = new string[] { "Piotr", "Rozalia", "Michał" },
                Item = null,
                ExpectionResult = true
            };
            yield return new Tester_Contains<int?>() {
                Items = new int?[] { 0, 44, 21, null, 4 },
                Item = null,
                ExpectionResult = false
            };
            yield return new Tester_Contains<bool?>() {
                Items = new bool?[] { false, false, false },
                Item = true,
                ExpectionResult = true
            };
            yield return new Tester_Contains<float?>() {
                Items = new float?[] { 4.44F, .69F, 10F, 999.99F },
                Item = 999.99F,
                ExpectionResult = false
            };
            yield return new Tester_Contains<Point>() {
                Items = new Point[] { new Point { X = 0, Y = 0 }, new Point { X = -1, Y = 1 }, new Point { X = 2, Y = 5 }, null, new Point() },
                Item = null,
                ExpectionResult = false
            };
        }
    }
}

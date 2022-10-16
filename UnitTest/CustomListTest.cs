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

        public static IEnumerable<ITester_AddItem> AddOneElement() {
            yield return new Tester_AddItem<string>() {
                Items = new string[]{ },  
                Data = "Piotr",
                ExpectedResult = 1
            };
            yield return new Tester_AddItem<int>() {
                Items = new int[] {0, 44, 21, 3, 4 },
                Data = 10,
                ExpectedResult = 6
            };
            yield return new Tester_AddItem<bool>() { 
                Items = new bool[] {true, false, false},
                Data = false,
                ExpectedResult = 4
            };
            yield return new Tester_AddItem<float>() { 
                Items = new float[] {4.44F, .69F, 10F, 999.99F},
                Data = 100.55F,
                ExpectedResult = 5
            };
            yield return new Tester_AddItem<Point>() {
                Items = new Point[] { new Point { X = 0, Y = 0 }, new Point { X = -1, Y = 1 }, new Point { X = 2, Y = 5 } },
                Data = new Point { X = -10, Y = 100 },
                ExpectedResult = 4
            };
        }

        public static IEnumerable<ITester_AddItems> AddMoreElement() {
            yield return new Tester_AddItems<string>() {
                Items = new string[] { },
                Datas = new string[] { "Piotr", "Karolina", "Maria", "Rafał"},
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
                Datas = new float[] { .0001F, 1000.01F},
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
    }
}

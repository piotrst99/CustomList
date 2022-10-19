using NUnit.Framework;
using P1_CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.TestCase {
    public interface ITester_AddItem {
        void GetCount_AddItem_IsCorrect();
        void GetCount_AddItem_IsNotCorrect();
        void Compare_AddItem_IsCorrect();
        void Compare_AddItem_IsNotCorrect();
    }

    public class Tester_AddItem<T> : ITester_AddItem {
        private CustomList<T> _customList;

        public T[] Items { set { _customList.AddRange(value); } }
        public T? Data { get; set; }
        public int ExpectedResult { get; set; }
        public T? ObjectToCheck { get; set; }

        public Tester_AddItem() {
            _customList = new CustomList<T>();
        }

        public void GetCount_AddItem_IsCorrect() {
            _customList.Add(Data);
            Assert.AreEqual(_customList.Count, ExpectedResult);
        }

        public void GetCount_AddItem_IsNotCorrect() {
            _customList.Add(Data);
            Assert.AreNotEqual(_customList.Count, 0);
            Assert.AreNotEqual(_customList.Count, ExpectedResult + 1);
            Assert.AreNotEqual(_customList.Count, ExpectedResult - 1);
        }

        public void Compare_AddItem_IsCorrect() {
            _customList.Add(Data);
            Assert.AreEqual(_customList[_customList.Count - 1], Data);
        }

        public void Compare_AddItem_IsNotCorrect() {
            _customList.Add(Data);
            Assert.AreNotEqual(_customList[_customList.Count - 1], ObjectToCheck);
        }
    }
}

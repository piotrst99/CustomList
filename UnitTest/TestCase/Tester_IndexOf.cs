using NUnit.Framework;
using P1_CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.TestCase {
    public interface ITester_IndexOf {
        void Compare_InsertOf_IsCorrect();
        void Compare_InsertOf_IsNotCorrect();
    }

    public class Tester_IndexOf<T> : ITester_IndexOf {
        private CustomList<T> _customList;

        public T[] Items { set { _customList.AddRange(value); } }
        public T? Item { get; set; }
        public int ExpectionResult { get; set; }

        public Tester_IndexOf() {
            _customList = new CustomList<T>();
        }

        public void Compare_InsertOf_IsCorrect() {
            int value = _customList.IndexOf(Item);
            Assert.AreEqual(value, ExpectionResult);
        }

        public void Compare_InsertOf_IsNotCorrect() {
            int value = _customList.IndexOf(Item);
            Assert.AreNotEqual(value, ExpectionResult + 1);
            Assert.AreNotEqual(value, ExpectionResult - 1);
            if(value != -1) Assert.AreNotEqual(value, -1);
            if (value != _customList.Count - 1) Assert.AreNotEqual(value, _customList.Count - 1);
        }
    }
}

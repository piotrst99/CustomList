using NUnit.Framework;
using P1_CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.TestCase {
    public interface ITester_Contains{
        void Compare_Contains_IsCorrect();
        void Compare_Contains_IsNotCorrect();
    }

    public class Tester_Contains<T> : ITester_Contains {
        private CustomList<T> _customList;

        public T[] Items { set { _customList.AddRange(value); } }
        public T? Item { get; set; }
        public bool ExpectionResult { get; set; }

        public Tester_Contains() {
            _customList = new CustomList<T>();
        }

        public void Compare_Contains_IsCorrect() {
            bool value = _customList.Contains(Item);
            Assert.AreEqual(value, ExpectionResult);
        }

        public void Compare_Contains_IsNotCorrect() {
            bool value = _customList.Contains(Item);
            Assert.AreNotEqual(value, ExpectionResult);
        }
    }
}

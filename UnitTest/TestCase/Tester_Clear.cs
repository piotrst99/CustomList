using NUnit.Framework;
using P1_CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.TestCase {
    public interface ITester_Clear {
        void GetCount_Clear_IsCorrect();
        void GetCount_Clear_IsNotCorrect();
    }

    public class Tester_Clear<T> : ITester_Clear {
        private CustomList<T> _customList;

        public T[] Items { set { _customList.AddRange(value); } }

        public Tester_Clear() {
            _customList = new CustomList<T>();
        }

        public void GetCount_Clear_IsCorrect() {
            _customList.Clear();
            Assert.IsTrue(_customList.Count == 0);
        }

        public void GetCount_Clear_IsNotCorrect() {
            _customList.Clear();
            Assert.IsFalse(_customList.Count == -1);
            Assert.IsFalse(_customList.Count == 1);
        }
    }
}
